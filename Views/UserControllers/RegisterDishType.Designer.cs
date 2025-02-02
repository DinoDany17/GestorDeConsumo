﻿namespace GestorDeConsumo.Views.UserControllers
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
            ButtonAddDishType.Enabled = false;
            ButtonAddDishType.Location = new Point(361, 38);
            ButtonAddDishType.Name = "ButtonAddDishType";
            ButtonAddDishType.Size = new Size(131, 23);
            ButtonAddDishType.TabIndex = 3;
            ButtonAddDishType.Text = "Agregar platillo";
            ButtonAddDishType.UseVisualStyleBackColor = true;
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
            TableDishType.BackgroundColor = Color.Gray;
            TableDishType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableDishType.Columns.AddRange(new DataGridViewColumn[] { Id, name, cost, Delete });
            TableDishType.EditMode = DataGridViewEditMode.EditOnKeystroke;
            TableDishType.Location = new Point(19, 76);
            TableDishType.Name = "TableDishType";
            TableDishType.RowHeadersVisible = false;
            TableDishType.RowTemplate.Height = 25;
            TableDishType.Size = new Size(1006, 468);
            TableDishType.TabIndex = 10;
            TableDishType.CellBeginEdit += TableDishType_CellBeginEdit;
            TableDishType.CellContentClick += TableDishType_CellContentClick;
            TableDishType.CellEndEdit += TableDishType_CellEndEdit;
            // 
            // CostNumericDropDown
            // 
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
            cost.HeaderText = "Costo";
            cost.Name = "cost";
            cost.Resizable = DataGridViewTriState.True;
            cost.Width = 200;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "X";
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
