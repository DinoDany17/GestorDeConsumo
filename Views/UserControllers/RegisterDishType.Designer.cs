namespace GestorDeConsumo.Views.UserControllers
{
    partial class RegisterDishType
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ButtonAddDishType = new Button();
            LabelDishType = new Label();
            DishTypeTextBox = new TextBox();
            LabelCost = new Label();
            TableDishType = new DataGridView();
            CostNumericDropDown = new NumericUpDown();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)TableDishType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CostNumericDropDown).BeginInit();
            SuspendLayout();
            // 
            // ButtonAddDishType
            // 
            ButtonAddDishType.BackColor = Color.FromArgb(165, 142, 116);
            ButtonAddDishType.Enabled = false;
            ButtonAddDishType.FlatAppearance.BorderSize = 0;
            ButtonAddDishType.FlatStyle = FlatStyle.Flat;
            ButtonAddDishType.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonAddDishType.Location = new Point(361, 38);
            ButtonAddDishType.Name = "ButtonAddDishType";
            ButtonAddDishType.Size = new Size(131, 23);
            ButtonAddDishType.TabIndex = 3;
            ButtonAddDishType.Text = "Agregar platillo";
            ButtonAddDishType.UseVisualStyleBackColor = false;
            ButtonAddDishType.Click += ButtonAddDishType_Click;
            // 
            // LabelDishType
            // 
            LabelDishType.AutoSize = true;
            LabelDishType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDishType.Location = new Point(19, 21);
            LabelDishType.Name = "LabelDishType";
            LabelDishType.Size = new Size(113, 15);
            LabelDishType.TabIndex = 6;
            LabelDishType.Text = "Nombre del platillo";
            // 
            // DishTypeTextBox
            // 
            DishTypeTextBox.BackColor = Color.White;
            DishTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            DishTypeTextBox.Location = new Point(19, 39);
            DishTypeTextBox.Name = "DishTypeTextBox";
            DishTypeTextBox.Size = new Size(199, 23);
            DishTypeTextBox.TabIndex = 1;
            DishTypeTextBox.TextChanged += DishTypeTextBox_TextChanged;
            // 
            // LabelCost
            // 
            LabelCost.AutoSize = true;
            LabelCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCost.Location = new Point(224, 21);
            LabelCost.Name = "LabelCost";
            LabelCost.Size = new Size(38, 15);
            LabelCost.TabIndex = 9;
            LabelCost.Text = "Costo";
            // 
            // TableDishType
            // 
            TableDishType.AllowUserToAddRows = false;
            TableDishType.AllowUserToDeleteRows = false;
            TableDishType.AllowUserToResizeColumns = false;
            TableDishType.AllowUserToResizeRows = false;
            TableDishType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableDishType.BackgroundColor = Color.White;
            TableDishType.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(66, 69, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 239, 205);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TableDishType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TableDishType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDishType.Columns.AddRange(new DataGridViewColumn[] { Id, name, cost, Delete });
            TableDishType.EditMode = DataGridViewEditMode.EditOnKeystroke;
            TableDishType.GridColor = SystemColors.ActiveCaptionText;
            TableDishType.Location = new Point(19, 76);
            TableDishType.Name = "TableDishType";
            TableDishType.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            TableDishType.RowHeadersVisible = false;
            TableDishType.RowTemplate.Height = 25;
            TableDishType.Size = new Size(1006, 468);
            TableDishType.TabIndex = 10;
            TableDishType.CellBeginEdit += TableDishType_CellBeginEdit;
            TableDishType.CellContentClick += TableDishType_CellContentClick;
            TableDishType.CellEndEdit += TableDishType_CellEndEdit;
            TableDishType.CellPainting += TableDishType_CellPainting;
            // 
            // CostNumericDropDown
            // 
            CostNumericDropDown.BackColor = Color.White;
            CostNumericDropDown.BorderStyle = BorderStyle.FixedSingle;
            CostNumericDropDown.DecimalPlaces = 2;
            CostNumericDropDown.Location = new Point(224, 39);
            CostNumericDropDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            CostNumericDropDown.Name = "CostNumericDropDown";
            CostNumericDropDown.Size = new Size(131, 23);
            CostNumericDropDown.TabIndex = 2;
            CostNumericDropDown.ThousandsSeparator = true;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Platillo";
            name.MinimumWidth = 200;
            name.Name = "name";
            // 
            // cost
            // 
            dataGridViewCellStyle2.NullValue = null;
            cost.DefaultCellStyle = dataGridViewCellStyle2;
            cost.HeaderText = "Costo";
            cost.Name = "cost";
            cost.Resizable = DataGridViewTriState.True;
            cost.Width = 200;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(165, 142, 116);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 239, 205);
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "X";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 50;
            // 
            // RegisterDishType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CostNumericDropDown);
            Controls.Add(TableDishType);
            Controls.Add(LabelCost);
            Controls.Add(DishTypeTextBox);
            Controls.Add(ButtonAddDishType);
            Controls.Add(LabelDishType);
            Name = "RegisterDishType";
            Size = new Size(1045, 565);
            Load += RegisterDishType_Load;
            ((System.ComponentModel.ISupportInitialize)TableDishType).EndInit();
            ((System.ComponentModel.ISupportInitialize)CostNumericDropDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddDishType;
        private Label LabelDishType;
        private TextBox DishTypeTextBox;
        private Label LabelCost;
        private DataGridView TableDishType;
        private NumericUpDown CostNumericDropDown;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewButtonColumn Delete;
    }
}
