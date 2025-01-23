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
            ButtonFingerprint = new Button();
            LabelEmployeeName = new Label();
            TableEmployee = new DataGridView();
            TextBoxName = new TextBox();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            fingerprint = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TableEmployee).BeginInit();
            SuspendLayout();
            // 
            // ButtonFingerprint
            // 
            ButtonFingerprint.Enabled = false;
            ButtonFingerprint.Location = new Point(458, 38);
            ButtonFingerprint.Name = "ButtonFingerprint";
            ButtonFingerprint.Size = new Size(131, 23);
            ButtonFingerprint.TabIndex = 5;
            ButtonFingerprint.Text = "Leer huella digital";
            ButtonFingerprint.UseVisualStyleBackColor = true;
            ButtonFingerprint.Click += ButtonFingerprint_Click;
            // 
            // LabelEmployeeName
            // 
            LabelEmployeeName.AutoSize = true;
            LabelEmployeeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEmployeeName.Location = new Point(19, 21);
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
            TableEmployee.BackgroundColor = SystemColors.ControlLight;
            TableEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableEmployee.Columns.AddRange(new DataGridViewColumn[] { id, name, fingerprint, delete });
            TableEmployee.EditMode = DataGridViewEditMode.EditOnKeystroke;
            TableEmployee.Location = new Point(19, 75);
            TableEmployee.Name = "TableEmployee";
            TableEmployee.RowHeadersVisible = false;
            TableEmployee.RowTemplate.Height = 25;
            TableEmployee.Size = new Size(1006, 468);
            TableEmployee.TabIndex = 3;
            TableEmployee.CellBeginEdit += TableEmployee_CellBeginEdit;
            TableEmployee.CellContentClick += TableEmployee_CellContentClick;
            TableEmployee.CellEndEdit += TableEmployee_CellEndEdit;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(19, 39);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(433, 23);
            TextBoxName.TabIndex = 7;
            TextBoxName.TextChanged += TextBoxName_TextChanged;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Nombre";
            name.MinimumWidth = 200;
            name.Name = "name";
            // 
            // fingerprint
            // 
            fingerprint.HeaderText = "Huella dactilar";
            fingerprint.Name = "fingerprint";
            fingerprint.ReadOnly = true;
            fingerprint.Resizable = DataGridViewTriState.True;
            fingerprint.SortMode = DataGridViewColumnSortMode.Automatic;
            fingerprint.Text = "Editar";
            fingerprint.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "X";
            delete.Width = 50;
            // 
            // RegisterEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TextBoxName);
            Controls.Add(ButtonFingerprint);
            Controls.Add(LabelEmployeeName);
            Controls.Add(TableEmployee);
            Name = "RegisterEmployee";
            Size = new Size(1045, 565);
            Load += RegisterEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)TableEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonFingerprint;
        private Label LabelEmployeeName;
        private DataGridView TableEmployee;
        private TextBox TextBoxName;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewButtonColumn fingerprint;
        private DataGridViewButtonColumn delete;
    }
}
