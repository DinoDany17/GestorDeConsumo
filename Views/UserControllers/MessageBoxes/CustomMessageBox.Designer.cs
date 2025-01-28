namespace GestorDeConsumo.Views.UserControllers.MessageBoxes
{
    partial class CustomMessageBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            TopPanel = new Panel();
            IconPictureBox = new PictureBox();
            ConfirmLabel = new Label();
            ButtonAgree = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(224, 145, 50);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(250, 35);
            TopPanel.TabIndex = 2;
            // 
            // IconPictureBox
            // 
            IconPictureBox.BackColor = Color.Transparent;
            IconPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            IconPictureBox.InitialImage = null;
            IconPictureBox.Location = new Point(10, 45);
            IconPictureBox.Name = "IconPictureBox";
            IconPictureBox.Size = new Size(50, 50);
            IconPictureBox.TabIndex = 3;
            IconPictureBox.TabStop = false;
            // 
            // ConfirmLabel
            // 
            ConfirmLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmLabel.Location = new Point(75, 45);
            ConfirmLabel.Name = "ConfirmLabel";
            ConfirmLabel.Size = new Size(165, 50);
            ConfirmLabel.TabIndex = 4;
            ConfirmLabel.Text = "TextHere";
            // 
            // ButtonAgree
            // 
            ButtonAgree.BackColor = Color.FromArgb(165, 142, 116);
            ButtonAgree.FlatAppearance.BorderSize = 0;
            ButtonAgree.FlatStyle = FlatStyle.Flat;
            ButtonAgree.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonAgree.Location = new Point(130, 112);
            ButtonAgree.Name = "ButtonAgree";
            ButtonAgree.Size = new Size(110, 25);
            ButtonAgree.TabIndex = 5;
            ButtonAgree.Text = "Aceptar";
            ButtonAgree.UseVisualStyleBackColor = false;
            ButtonAgree.Click += ButtonAgree_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(165, 142, 116);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonCancel.Location = new Point(10, 112);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(110, 25);
            ButtonCancel.TabIndex = 6;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = false;
            ButtonCancel.Visible = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 150);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonAgree);
            Controls.Add(ConfirmLabel);
            Controls.Add(IconPictureBox);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)IconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private PictureBox IconPictureBox;
        private Label ConfirmLabel;
        private Button ButtonAgree;
        private Button ButtonCancel;
    }
}
