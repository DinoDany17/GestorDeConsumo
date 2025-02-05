namespace GestorDeConsumo.Views.UserControllers
{
    partial class BackupRestore
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
            LabelBackup = new Label();
            SelectedBackupTextBox = new TextBox();
            ButtonBackup = new Button();
            LabelRestore = new Label();
            label1 = new Label();
            ButtonLoadBackup = new Button();
            ButtonRestore = new Button();
            SuspendLayout();
            // 
            // LabelBackup
            // 
            LabelBackup.AutoSize = true;
            LabelBackup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBackup.Location = new Point(14, 17);
            LabelBackup.Name = "LabelBackup";
            LabelBackup.Size = new Size(80, 21);
            LabelBackup.TabIndex = 0;
            LabelBackup.Text = "Respaldo";
            // 
            // SelectedBackupTextBox
            // 
            SelectedBackupTextBox.BackColor = Color.White;
            SelectedBackupTextBox.BorderStyle = BorderStyle.FixedSingle;
            SelectedBackupTextBox.Enabled = false;
            SelectedBackupTextBox.Location = new Point(14, 153);
            SelectedBackupTextBox.Name = "SelectedBackupTextBox";
            SelectedBackupTextBox.ReadOnly = true;
            SelectedBackupTextBox.Size = new Size(457, 23);
            SelectedBackupTextBox.TabIndex = 1;
            // 
            // ButtonBackup
            // 
            ButtonBackup.BackColor = Color.FromArgb(165, 142, 116);
            ButtonBackup.FlatAppearance.BorderSize = 0;
            ButtonBackup.FlatStyle = FlatStyle.Flat;
            ButtonBackup.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonBackup.Location = new Point(14, 48);
            ButtonBackup.Name = "ButtonBackup";
            ButtonBackup.Size = new Size(195, 23);
            ButtonBackup.TabIndex = 2;
            ButtonBackup.Text = "Respaldar base de datos";
            ButtonBackup.UseVisualStyleBackColor = false;
            ButtonBackup.Click += ButtonBackup_Click;
            // 
            // LabelRestore
            // 
            LabelRestore.AutoSize = true;
            LabelRestore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRestore.Location = new Point(14, 104);
            LabelRestore.Name = "LabelRestore";
            LabelRestore.Size = new Size(82, 21);
            LabelRestore.TabIndex = 3;
            LabelRestore.Text = "Restaurar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(14, 135);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 4;
            label1.Text = "Localización del respaldo";
            // 
            // ButtonLoadBackup
            // 
            ButtonLoadBackup.BackColor = Color.FromArgb(165, 142, 116);
            ButtonLoadBackup.FlatAppearance.BorderSize = 0;
            ButtonLoadBackup.FlatStyle = FlatStyle.Flat;
            ButtonLoadBackup.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonLoadBackup.Location = new Point(488, 153);
            ButtonLoadBackup.Name = "ButtonLoadBackup";
            ButtonLoadBackup.Size = new Size(103, 23);
            ButtonLoadBackup.TabIndex = 5;
            ButtonLoadBackup.Text = "Cargar respaldo";
            ButtonLoadBackup.UseVisualStyleBackColor = false;
            ButtonLoadBackup.Click += ButtonLoadBackup_Click;
            // 
            // ButtonRestore
            // 
            ButtonRestore.BackColor = Color.FromArgb(165, 142, 116);
            ButtonRestore.Enabled = false;
            ButtonRestore.FlatAppearance.BorderSize = 0;
            ButtonRestore.FlatStyle = FlatStyle.Flat;
            ButtonRestore.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonRestore.Location = new Point(14, 195);
            ButtonRestore.Name = "ButtonRestore";
            ButtonRestore.Size = new Size(103, 23);
            ButtonRestore.TabIndex = 6;
            ButtonRestore.Text = "Restaurar";
            ButtonRestore.UseVisualStyleBackColor = false;
            ButtonRestore.Click += ButtonRestore_Click;
            // 
            // BackupRestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedBackupTextBox);
            Controls.Add(ButtonRestore);
            Controls.Add(ButtonLoadBackup);
            Controls.Add(label1);
            Controls.Add(LabelRestore);
            Controls.Add(ButtonBackup);
            Controls.Add(LabelBackup);
            Name = "BackupRestore";
            Size = new Size(1045, 565);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelBackup;
        private TextBox SelectedBackupTextBox;
        private Button ButtonBackup;
        private Label LabelRestore;
        private Label label1;
        private Button ButtonLoadBackup;
        private Button ButtonRestore;
    }
}
