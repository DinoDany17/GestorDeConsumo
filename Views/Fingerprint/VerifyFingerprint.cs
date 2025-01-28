using GestorDeConsumo.Controllers;
using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;

namespace GestorDeConsumo.Views.Fingerprint
{
    public partial class VerifyFingerprint : Form, DPFP.Capture.EventHandler
    {
        // Dragging
        private bool dragging = false;
        Point start_point = new Point(0, 0);

        // Functionality
        delegate void Function();
        Employee[] employees = new Employee[0];
        DPFP.Capture.Capture? capture;
        private DPFP.Verification.Verification? verificator;
        public delegate void OnTemplateEventHandler(Employee? employee);
        public event OnTemplateEventHandler? OnTemplate;
        public VerifyFingerprint()
        {
            InitializeComponent();
        }

        private void VerifyFingerprint_Load(object sender, EventArgs e)
        {
            employees = EmployeeController.GetAllEmployees();
            if (employees.Length == 0)
            {
                CustomMessageBox.Show("No hay empleados registrados", CustomMessageBoxType.Info);
            }
            capture = new DPFP.Capture.Capture();
            verificator = new DPFP.Verification.Verification();
            if (capture != null)
            {
                capture.EventHandler = this;
                capture.StartCapture();
            }
            else
            {
                CustomMessageBox.Show("No se pudo iniciar la captura", CustomMessageBoxType.Error);
                CloseDialog(DialogResult.Abort);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                try
                {
                    capture.StopCapture();
                    CloseDialog(DialogResult.Cancel);
                }
                catch
                {
                    CustomMessageBox.Show("No se pudo detener la captura", CustomMessageBoxType.Error);
                }
            }
            Close();
        }

        #region EventHandler Members:
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            ChangeStatus("Levante el dedo");
            Process(Sample);
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            ChangeStatus("Leyendo huella");
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            ChangeStatus("Vuelva a poner el dedo en el lector");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            ChangeStatus("Ponga el dedo en el lector");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            ChangeStatus("Vuelva a conectar el lector");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                ChangeStatus("La calidad de la muestra es BUENA");
            else
                ChangeStatus("La calidad de la muestra es MALA");
        }
        #endregion

        #region Form EventHandler Members:
        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
            DPFP.FeatureSet? features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            if (features != null)
            {
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;

                foreach (Employee employee in employees)
                {
                    stream = new MemoryStream(employee.fingerprint);
                    template = new DPFP.Template(stream);

                    verificator?.Verify(features, template, ref result);
                    if (result.Verified)
                    {
                        OnTemplate?.Invoke(employee);
                        capture?.StopCapture();
                        CloseDialog(DialogResult.OK);
                        break;
                    }
                }
            }
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
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void ChangeStatus(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                StatusTextBox.Text = message;
            }));
        }

        private void DrawPicture(Bitmap? bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                if (bitmap == null)
                {
                    FingerprintPictureBox.Image = null;
                }
                else
                {
                    FingerprintPictureBox.Image = new Bitmap(bitmap, FingerprintPictureBox.Size);
                }
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

        private void VerifyFingerprint_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray, 1);
            e.Graphics.DrawRectangle(pen, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray, 1);
            e.Graphics.DrawLine(pen, 0, 0, TopPanel.Width, 0);
            e.Graphics.DrawLine(pen, 0, 0, 0, TopPanel.Height - 1);
            e.Graphics.DrawLine(pen, TopPanel.Width - 1, 0, TopPanel.Width - 1, TopPanel.Height - 1);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                start_point = new Point(e.X, e.Y);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
