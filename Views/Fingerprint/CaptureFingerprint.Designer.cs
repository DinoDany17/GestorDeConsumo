namespace GestorDeConsumo.Views.Fingerprint
{
    partial class CaptureFingerprint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureFingerprint));
            FingerprintPictureBox = new PictureBox();
            TitleLabel = new Label();
            LogBox = new RichTextBox();
            ButtonClose = new Button();
            StatusLabel = new Label();
            TopPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).BeginInit();
            SuspendLayout();
            // 
            // FingerprintPictureBox
            // 
            FingerprintPictureBox.BackColor = Color.White;
            FingerprintPictureBox.Location = new Point(12, 50);
            FingerprintPictureBox.Name = "FingerprintPictureBox";
            FingerprintPictureBox.Size = new Size(379, 426);
            FingerprintPictureBox.TabIndex = 0;
            FingerprintPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(476, 50);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(246, 30);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Capturar huella digital";
            // 
            // LogBox
            // 
            LogBox.BackColor = Color.White;
            LogBox.BorderStyle = BorderStyle.None;
            LogBox.Location = new Point(416, 93);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            LogBox.Size = new Size(348, 383);
            LogBox.TabIndex = 3;
            LogBox.Text = "";
            // 
            // ButtonClose
            // 
            ButtonClose.BackColor = Color.FromArgb(165, 142, 116);
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonClose.Location = new Point(689, 482);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(75, 23);
            ButtonClose.TabIndex = 4;
            ButtonClose.Text = "Cerrar";
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(12, 486);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(146, 15);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Se necesitan 5 huellas más";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(224, 145, 50);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(784, 35);
            TopPanel.TabIndex = 10;
            TopPanel.Paint += TopPanel_Paint;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // CaptureFingerprint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 513);
            Controls.Add(TopPanel);
            Controls.Add(StatusLabel);
            Controls.Add(ButtonClose);
            Controls.Add(LogBox);
            Controls.Add(TitleLabel);
            Controls.Add(FingerprintPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CaptureFingerprint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CaptureFingerprint";
            FormClosed += CaptureFingerprint_FormClosed;
            Load += CaptureFingerprint_Load;
            Paint += CaptureFingerprint_Paint;
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FingerprintPictureBox;
        private Label TitleLabel;
        private RichTextBox LogBox;
        private Button ButtonClose;
        private Label StatusLabel;
        private Panel TopPanel;
    }
}