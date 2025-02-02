namespace GestorDeConsumo.Views.UserControllers
{
    partial class RegisterCosumption
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
            components = new System.ComponentModel.Container();
            databaseConnectionBindingSource = new BindingSource(components);
            TableConsumption = new DataGridView();
            ComboBoxDishType = new ComboBox();
            LabelDishType = new Label();
            ButtonFingerprint = new Button();
            Id = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Platillo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableConsumption).BeginInit();
            SuspendLayout();
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // TableConsumption
            // 
            TableConsumption.AllowUserToAddRows = false;
            TableConsumption.AllowUserToDeleteRows = false;
            TableConsumption.AllowUserToResizeColumns = false;
            TableConsumption.AllowUserToResizeRows = false;
            TableConsumption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableConsumption.BackgroundColor = Color.Gray;
            TableConsumption.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableConsumption.Columns.AddRange(new DataGridViewColumn[] { Id, Hora, Empleado, Platillo, Eliminar });
            TableConsumption.EditMode = DataGridViewEditMode.EditProgrammatically;
            TableConsumption.Location = new Point(19, 76);
            TableConsumption.Name = "TableConsumption";
            TableConsumption.RowHeadersVisible = false;
            TableConsumption.RowTemplate.Height = 25;
            TableConsumption.Size = new Size(1006, 468);
            TableConsumption.TabIndex = 0;
            TableConsumption.CellContentClick += TableConsumption_CellContentClick;
            // 
            // ComboBoxDishType
            // 
            ComboBoxDishType.DropDownHeight = 110;
            ComboBoxDishType.FlatStyle = FlatStyle.Flat;
            ComboBoxDishType.FormattingEnabled = true;
            ComboBoxDishType.IntegralHeight = false;
            ComboBoxDishType.ItemHeight = 15;
            ComboBoxDishType.Location = new Point(19, 40);
            ComboBoxDishType.Name = "ComboBoxDishType";
            ComboBoxDishType.Size = new Size(199, 23);
            ComboBoxDishType.TabIndex = 1;
            ComboBoxDishType.SelectedIndexChanged += ComboBoxDishType_SelectedIndexChanged;
            ComboBoxDishType.Click += ComboBoxDishType_Click;
            // 
            // LabelDishType
            // 
            LabelDishType.AutoSize = true;
            LabelDishType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDishType.Location = new Point(19, 22);
            LabelDishType.Name = "LabelDishType";
            LabelDishType.Size = new Size(88, 15);
            LabelDishType.TabIndex = 2;
            LabelDishType.Text = "Tipo de platillo";
            // 
            // ButtonFingerprint
            // 
            ButtonFingerprint.Enabled = false;
            ButtonFingerprint.Location = new Point(224, 39);
            ButtonFingerprint.Name = "ButtonFingerprint";
            ButtonFingerprint.Size = new Size(199, 23);
            ButtonFingerprint.TabIndex = 2;
            ButtonFingerprint.Text = "Leer huella digital";
            ButtonFingerprint.UseVisualStyleBackColor = true;
            ButtonFingerprint.Click += ButtonFingerprint_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // Empleado
            // 
            Empleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 200;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            // 
            // Platillo
            // 
            Platillo.HeaderText = "Platillo";
            Platillo.Name = "Platillo";
            Platillo.ReadOnly = true;
            Platillo.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "X";
            Eliminar.Width = 50;
            // 
            // RegisterCosumption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonFingerprint);
            Controls.Add(LabelDishType);
            Controls.Add(ComboBoxDishType);
            Controls.Add(TableConsumption);
            Name = "RegisterCosumption";
            Size = new Size(1045, 565);
            Load += RegisterCosumption_Load;
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableConsumption).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource databaseConnectionBindingSource;
        private DataGridView TableConsumption;
        private ComboBox ComboBoxDishType;
        private Label LabelDishType;
        private Button ButtonFingerprint;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Platillo;
        private DataGridViewButtonColumn Eliminar;
    }
}
