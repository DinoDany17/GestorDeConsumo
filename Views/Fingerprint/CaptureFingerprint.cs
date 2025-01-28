using GestorDeConsumo.Views.UserControllers.MessageBoxes;

namespace GestorDeConsumo.Views.Fingerprint
{
    public partial class CaptureFingerprint : Form, DPFP.Capture.EventHandler
    {
        delegate void Function();
        private DPFP.Capture.Capture? Capturer;
        private DPFP.Processing.Enrollment? Enroller;
        public delegate void OnTemplateEventHandler(DPFP.Template? template);
        public event OnTemplateEventHandler? OnTemplate;
        public CaptureFingerprint()
        {
            InitializeComponent();
        }

        private void CaptureFingerprint_Load(object sender, EventArgs e)
        {
            Capturer = new DPFP.Capture.Capture();
            Enroller = new DPFP.Processing.Enrollment();
            if (Capturer != null && Enroller != null)
            {
                Capturer.EventHandler = this;
                UpdateStatus();
                Capturer.StartCapture();
            }
            else
            {
                CustomMessageBox.Show("No se pudo iniciar la captura", CustomMessageBoxType.Error);
                CloseDialog(DialogResult.Abort);
            }
        }

        private void CaptureFingerprint_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    CustomMessageBox.Show("No se pudo detener la captura", CustomMessageBoxType.Error);
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            CloseDialog(DialogResult.Cancel);
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            AppendLog("La muestra ha sido capturada");
            Process(Sample);
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            AppendLog("Se ha registrado un toque en el lector");
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            AppendLog("El dedo fue removido del lector");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            AppendLog("El Lector de huellas ha sido conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            AppendLog("El Lector de huellas ha sido desconectado");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                AppendLog("La calidad de la muestra es BUENA");
            else
                AppendLog("La calidad de la muestra es MALA");
        }

        #endregion
        #region Form Event Handlers:

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet? features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null && OnTemplate != null) try
            {
                AppendLog("Se guardó la huella correctamente");
                Enroller?.AddFeatures(features);
            }
            finally
            {
                UpdateStatus();

                // Check if template has been created.
                switch (Enroller?.TemplateStatus)
                {
                    case DPFP.Processing.Enrollment.Status.Failed:
                        Enroller.Clear();
                        Capturer?.StopCapture();
                        UpdateStatus();
                        OnTemplate(null);
                        Capturer?.StartCapture();
                        AppendLog("Picalewe");
                        break;
                    case DPFP.Processing.Enrollment.Status.Ready:
                        OnTemplate(Enroller.Template);
                        Capturer?.StopCapture();
                        CloseDialog(DialogResult.OK);
                        break;
                }
            }
        }

        private void AppendLog(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                LogBox.AppendText(message + "\r\n");
            }));
        }

        protected Bitmap? ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap? bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected DPFP.FeatureSet? ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private void DrawPicture(Bitmap? bitmap)
        {
            if (bitmap == null)
            {
                FingerprintPictureBox.Image = null;
            }
            else
            {
                FingerprintPictureBox.Image = new Bitmap(bitmap, FingerprintPictureBox.Size);
            }
        }

        private void UpdateStatus()
        {
            this.Invoke(new Function(delegate ()
            {
                StatusLabel.Text = $"Se necesitan {Enroller?.FeaturesNeeded} huellas más";
            }));
        }

        private void CloseDialog(DialogResult result)
        {
            this.Invoke(new Function(delegate ()
            {
                this.DialogResult = result;
                this.Close();
            }));
        }

        #endregion
    }
}
