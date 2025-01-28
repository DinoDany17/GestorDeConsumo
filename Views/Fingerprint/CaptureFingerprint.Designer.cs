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
            FingerprintPictureBox = new PictureBox();
            TitleLabel = new Label();
            LogBox = new RichTextBox();
            ButtonClose = new Button();
            StatusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).BeginInit();
            SuspendLayout();
            // 
            // FingerprintPictureBox
            // 
            FingerprintPictureBox.BackColor = SystemColors.ButtonHighlight;
            FingerprintPictureBox.Location = new Point(12, 12);
            FingerprintPictureBox.Name = "FingerprintPictureBox";
            FingerprintPictureBox.Size = new Size(379, 426);
            FingerprintPictureBox.TabIndex = 0;
            FingerprintPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(488, 12);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(246, 30);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Capturar huella digital";
            // 
            // LogBox
            // 
            LogBox.BackColor = SystemColors.ButtonHighlight;
            LogBox.Location = new Point(428, 55);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            LogBox.Size = new Size(348, 383);
            LogBox.TabIndex = 3;
            LogBox.Text = "";
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(701, 444);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(75, 23);
            ButtonClose.TabIndex = 4;
            ButtonClose.Text = "Cerrar";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(12, 448);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(146, 15);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Se necesitan 5 huellas más";
            // 
            // CaptureFingerprint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(StatusLabel);
            Controls.Add(ButtonClose);
            Controls.Add(LogBox);
            Controls.Add(TitleLabel);
            Controls.Add(FingerprintPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaptureFingerprint";
            Text = "CaptureFingerprint";
            FormClosed += CaptureFingerprint_FormClosed;
            Load += CaptureFingerprint_Load;
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
    }
}