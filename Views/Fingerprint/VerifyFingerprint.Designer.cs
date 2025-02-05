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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyFingerprint));
            CloseButton = new Button();
            TitleLabel = new Label();
            FingerprintPictureBox = new PictureBox();
            StatusTextBox = new TextBox();
            TopPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(165, 142, 116);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.FromArgb(255, 239, 205);
            CloseButton.Location = new Point(316, 545);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Cerrar";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(71, 46);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(241, 30);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "Verificar huella digital";
            // 
            // FingerprintPictureBox
            // 
            FingerprintPictureBox.BackColor = Color.White;
            FingerprintPictureBox.Location = new Point(12, 113);
            FingerprintPictureBox.Name = "FingerprintPictureBox";
            FingerprintPictureBox.Size = new Size(379, 426);
            FingerprintPictureBox.TabIndex = 6;
            FingerprintPictureBox.TabStop = false;
            // 
            // StatusTextBox
            // 
            StatusTextBox.BackColor = Color.White;
            StatusTextBox.BorderStyle = BorderStyle.FixedSingle;
            StatusTextBox.Enabled = false;
            StatusTextBox.Location = new Point(12, 84);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ReadOnly = true;
            StatusTextBox.Size = new Size(379, 23);
            StatusTextBox.TabIndex = 8;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(224, 145, 50);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(402, 35);
            TopPanel.TabIndex = 9;
            TopPanel.Paint += TopPanel_Paint;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // VerifyFingerprint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 574);
            Controls.Add(TopPanel);
            Controls.Add(StatusTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(FingerprintPictureBox);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerifyFingerprint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifyFingerprint";
            Load += VerifyFingerprint_Load;
            Paint += VerifyFingerprint_Paint;
            ((System.ComponentModel.ISupportInitialize)FingerprintPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CloseButton;
        private Label TitleLabel;
        private PictureBox FingerprintPictureBox;
        private TextBox StatusTextBox;
        private Panel TopPanel;
    }
}