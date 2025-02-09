namespace GestorDeConsumo.Views.UserControllers
{
    partial class ReportGeneration
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
            RangeCalendar = new MonthCalendar();
            ReportTable = new DataGridView();
            CalendarLabel = new Label();
            ButtonGenerate = new Button();
            ButtonDownloadExcel = new Button();
            RangeLabel = new Label();
            EmpNumber = new DataGridViewTextBoxColumn();
            EmpName = new DataGridViewTextBoxColumn();
            DishType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ReportTable).BeginInit();
            SuspendLayout();
            // 
            // RangeCalendar
            // 
            RangeCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RangeCalendar.BackColor = Color.FromArgb(255, 239, 205);
            RangeCalendar.Location = new Point(764, 42);
            RangeCalendar.MaxDate = new DateTime(2025, 1, 30, 0, 0, 0, 0);
            RangeCalendar.MaxSelectionCount = 99;
            RangeCalendar.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            RangeCalendar.Name = "RangeCalendar";
            RangeCalendar.TabIndex = 0;
            RangeCalendar.TitleBackColor = Color.FromArgb(165, 142, 116);
            RangeCalendar.TrailingForeColor = SystemColors.ControlDark;
            RangeCalendar.DateChanged += RangeCalendar_DateChanged;
            // 
            // ReportTable
            // 
            ReportTable.AllowUserToAddRows = false;
            ReportTable.AllowUserToDeleteRows = false;
            ReportTable.AllowUserToResizeColumns = false;
            ReportTable.AllowUserToResizeRows = false;
            ReportTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ReportTable.BackgroundColor = Color.White;
            ReportTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(66, 69, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 239, 205);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ReportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportTable.Columns.AddRange(new DataGridViewColumn[] { EmpNumber, EmpName, DishType, Quantity, Total });
            ReportTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            ReportTable.GridColor = SystemColors.ActiveCaptionText;
            ReportTable.Location = new Point(16, 18);
            ReportTable.Name = "ReportTable";
            ReportTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ReportTable.RowHeadersVisible = false;
            ReportTable.RowTemplate.Height = 25;
            ReportTable.ScrollBars = ScrollBars.Vertical;
            ReportTable.Size = new Size(708, 531);
            ReportTable.TabIndex = 4;
            ReportTable.CellPainting += ReportTable_CellPainting;
            // 
            // CalendarLabel
            // 
            CalendarLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CalendarLabel.AutoSize = true;
            CalendarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CalendarLabel.Location = new Point(764, 18);
            CalendarLabel.Name = "CalendarLabel";
            CalendarLabel.Size = new Size(108, 15);
            CalendarLabel.TabIndex = 2;
            CalendarLabel.Text = "Rango del reporte";
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonGenerate.BackColor = Color.FromArgb(165, 142, 116);
            ButtonGenerate.FlatAppearance.BorderSize = 0;
            ButtonGenerate.FlatStyle = FlatStyle.Flat;
            ButtonGenerate.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonGenerate.Location = new Point(881, 497);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(131, 23);
            ButtonGenerate.TabIndex = 6;
            ButtonGenerate.Text = "Generar reporte";
            ButtonGenerate.UseVisualStyleBackColor = false;
            ButtonGenerate.Click += ButtonGenerate_Click;
            // 
            // ButtonDownloadExcel
            // 
            ButtonDownloadExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonDownloadExcel.BackColor = Color.FromArgb(165, 142, 116);
            ButtonDownloadExcel.Enabled = false;
            ButtonDownloadExcel.FlatAppearance.BorderSize = 0;
            ButtonDownloadExcel.FlatStyle = FlatStyle.Flat;
            ButtonDownloadExcel.ForeColor = Color.FromArgb(255, 239, 205);
            ButtonDownloadExcel.Location = new Point(881, 526);
            ButtonDownloadExcel.Name = "ButtonDownloadExcel";
            ButtonDownloadExcel.Size = new Size(131, 23);
            ButtonDownloadExcel.TabIndex = 7;
            ButtonDownloadExcel.Text = "Descargar Excel";
            ButtonDownloadExcel.UseVisualStyleBackColor = false;
            ButtonDownloadExcel.Click += ButtonDownloadExcel_Click;
            // 
            // RangeLabel
            // 
            RangeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RangeLabel.AutoSize = true;
            RangeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RangeLabel.Location = new Point(764, 232);
            RangeLabel.Name = "RangeLabel";
            RangeLabel.Size = new Size(0, 15);
            RangeLabel.TabIndex = 8;
            // 
            // EmpNumber
            // 
            EmpNumber.HeaderText = "Número de empleado";
            EmpNumber.Name = "EmpNumber";
            EmpNumber.Width = 150;
            // 
            // EmpName
            // 
            EmpName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmpName.HeaderText = "Nombre del empleado";
            EmpName.Name = "EmpName";
            // 
            // DishType
            // 
            DishType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishType.HeaderText = "Tipo de platillo";
            DishType.Name = "DishType";
            DishType.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Cantidad";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // ReportGeneration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RangeLabel);
            Controls.Add(ButtonDownloadExcel);
            Controls.Add(ButtonGenerate);
            Controls.Add(ReportTable);
            Controls.Add(CalendarLabel);
            Controls.Add(RangeCalendar);
            Name = "ReportGeneration";
            Size = new Size(1045, 565);
            Load += ReportGeneration_Load;
            ((System.ComponentModel.ISupportInitialize)ReportTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar RangeCalendar;
        private DataGridView ReportTable;
        private Label CalendarLabel;
        private Button ButtonGenerate;
        private Button ButtonDownloadExcel;
        private Label RangeLabel;
        private DataGridViewTextBoxColumn EmpNumber;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn DishType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
    }
}
