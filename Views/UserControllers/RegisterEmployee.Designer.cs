namespace GestorDeConsumo.Views.UserControllers
{
    partial class RegisterEmployee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ButtonFingerprint = new Button();
            LabelEmployeeName = new Label();
            TableEmployee = new DataGridView();
            TextBoxName = new TextBox();
            EmpNumberLabel = new Label();
            EmpNumberUpDown = new NumericUpDown();
            id = new DataGridViewTextBoxColumn();
            emp_number = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TableEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmpNumberUpDown).BeginInit();
            SuspendLayout();
            // 
            // ButtonFingerprint
            // 
            ButtonFingerprint.BackColor = Color.FromArgb(165, 142, 116);
            ButtonFingerprint.Enabled = false;
            ButtonFingerprint.FlatAppearance.BorderSize = 0;
            ButtonFingerprint.FlatStyle = FlatStyle.Flat;
            ButtonFingerprint.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonFingerprint.Location = new Point(707, 38);
            ButtonFingerprint.Name = "ButtonFingerprint";
            ButtonFingerprint.Size = new Size(131, 23);
            ButtonFingerprint.TabIndex = 5;
            ButtonFingerprint.Text = "Leer huella digital";
            ButtonFingerprint.UseVisualStyleBackColor = false;
            ButtonFingerprint.Click += ButtonFingerprint_Click;
            // 
            // LabelEmployeeName
            // 
            LabelEmployeeName.AutoSize = true;
            LabelEmployeeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEmployeeName.Location = new Point(268, 21);
            LabelEmployeeName.Name = "LabelEmployeeName";
            LabelEmployeeName.Size = new Size(131, 15);
            LabelEmployeeName.TabIndex = 6;
            LabelEmployeeName.Text = "Nombre del empleado";
            // 
            // TableEmployee
            // 
            TableEmployee.AllowUserToAddRows = false;
            TableEmployee.AllowUserToDeleteRows = false;
            TableEmployee.AllowUserToResizeColumns = false;
            TableEmployee.AllowUserToResizeRows = false;
            TableEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableEmployee.BackgroundColor = Color.White;
            TableEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(66, 69, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 239, 205);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TableEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TableEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableEmployee.Columns.AddRange(new DataGridViewColumn[] { id, emp_number, name, delete });
            TableEmployee.EditMode = DataGridViewEditMode.EditOnKeystroke;
            TableEmployee.GridColor = SystemColors.ActiveCaptionText;
            TableEmployee.Location = new Point(19, 75);
            TableEmployee.Name = "TableEmployee";
            TableEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            TableEmployee.RowHeadersVisible = false;
            TableEmployee.RowTemplate.Height = 25;
            TableEmployee.Size = new Size(1006, 468);
            TableEmployee.TabIndex = 3;
            TableEmployee.CellBeginEdit += TableEmployee_CellBeginEdit;
            TableEmployee.CellContentClick += TableEmployee_CellContentClick;
            TableEmployee.CellEndEdit += TableEmployee_CellEndEdit;
            TableEmployee.CellPainting += TableEmployee_CellPainting;
            // 
            // TextBoxName
            // 
            TextBoxName.BackColor = Color.White;
            TextBoxName.BorderStyle = BorderStyle.FixedSingle;
            TextBoxName.Location = new Point(268, 39);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(433, 23);
            TextBoxName.TabIndex = 7;
            TextBoxName.TextChanged += TextBoxName_TextChanged;
            // 
            // EmpNumberLabel
            // 
            EmpNumberLabel.AutoSize = true;
            EmpNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EmpNumberLabel.Location = new Point(19, 21);
            EmpNumberLabel.Name = "EmpNumberLabel";
            EmpNumberLabel.Size = new Size(131, 15);
            EmpNumberLabel.TabIndex = 9;
            EmpNumberLabel.Text = "Número del empleado";
            // 
            // EmpNumberUpDown
            // 
            EmpNumberUpDown.BorderStyle = BorderStyle.FixedSingle;
            EmpNumberUpDown.Location = new Point(19, 40);
            EmpNumberUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            EmpNumberUpDown.Name = "EmpNumberUpDown";
            EmpNumberUpDown.Size = new Size(243, 23);
            EmpNumberUpDown.TabIndex = 10;
            EmpNumberUpDown.ValueChanged += EmpNumberUpDown_ValueChanged;
            EmpNumberUpDown.KeyPress += EmpNumberUpDown_KeyPress;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // emp_number
            // 
            emp_number.HeaderText = "Número de empleado";
            emp_number.Name = "emp_number";
            emp_number.Width = 150;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nombre";
            name.MinimumWidth = 200;
            name.Name = "name";
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(165, 142, 116);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 239, 205);
            delete.DefaultCellStyle = dataGridViewCellStyle2;
            delete.FlatStyle = FlatStyle.Flat;
            delete.HeaderText = "";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "X";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 50;
            // 
            // RegisterEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EmpNumberUpDown);
            Controls.Add(EmpNumberLabel);
            Controls.Add(TextBoxName);
            Controls.Add(ButtonFingerprint);
            Controls.Add(LabelEmployeeName);
            Controls.Add(TableEmployee);
            Name = "RegisterEmployee";
            Size = new Size(1045, 565);
            Load += RegisterEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)TableEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmpNumberUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonFingerprint;
        private Label LabelEmployeeName;
        private DataGridView TableEmployee;
        private TextBox TextBoxName;
        private Label EmpNumberLabel;
        private NumericUpDown EmpNumberUpDown;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn emp_number;
        private DataGridViewTextBoxColumn name;
        private DataGridViewButtonColumn delete;
    }
}
