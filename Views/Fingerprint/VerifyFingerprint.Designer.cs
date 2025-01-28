namespace GestorDeConsumo.Views.Fingerprint
{
    partial class VerifyFingerprint
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
            CloseButton = new Button();
            TitleLabel = new Label();
            FingerprintPictureBox = new PictureBox();
            StatusTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(316, 509);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Cerrar";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(71, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(241, 30);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "Verificar huella digital";
            // 
            // FingerprintPictureBox
            // 
            FingerprintPictureBox.BackColor = SystemColors.ButtonHighlight;
            FingerprintPictureBox.Location = new Point(12, 76);
            FingerprintPictureBox.Name = "FingerprintPictureBox";
            FingerprintPictureBox.Size = new Size(379, 426);
            FingerprintPictureBox.TabIndex = 6;
            FingerprintPictureBox.TabStop = false;
            // 
            // StatusTextBox
            // 
            StatusTextBox.BackColor = SystemColors.ButtonHighlight;
            StatusTextBox.Location = new Point(12, 47);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ReadOnly = true;
            StatusTextBox.Size = new Size(379, 23);
            StatusTextBox.TabIndex = 8;
            // 
            // VerifyFingerprint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 540);
            Controls.Add(StatusTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(FingerprintPictureBox);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerifyFingerprint";
            Text = "VerifyFingerprint";
            Load += VerifyFingerprint_Load;
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CloseButton;
        private Label TitleLabel;
        private PictureBox FingerprintPictureBox;
        private TextBox StatusTextBox;
    }
}