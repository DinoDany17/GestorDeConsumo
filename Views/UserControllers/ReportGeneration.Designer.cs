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
            RangeCalendar = new MonthCalendar();
            ReportTable = new DataGridView();
            DishType = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            CalendarLabel = new Label();
            ButtonGenerate = new Button();
            ButtonDownloadExcel = new Button();
            RangeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ReportTable).BeginInit();
            SuspendLayout();
            // 
            // RangeCalendar
            // 
            RangeCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RangeCalendar.Location = new Point(764, 42);
            RangeCalendar.MaxDate = new DateTime(2025, 1, 30, 0, 0, 0, 0);
            RangeCalendar.MaxSelectionCount = 99;
            RangeCalendar.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            RangeCalendar.Name = "RangeCalendar";
            RangeCalendar.TabIndex = 0;
            RangeCalendar.DateChanged += RangeCalendar_DateChanged;
            // 
            // ReportTable
            // 
            ReportTable.AllowUserToAddRows = false;
            ReportTable.AllowUserToDeleteRows = false;
            ReportTable.AllowUserToResizeColumns = false;
            ReportTable.AllowUserToResizeRows = false;
            ReportTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ReportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportTable.Columns.AddRange(new DataGridViewColumn[] { DishType, Cost, Quantity, Total });
            ReportTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            ReportTable.Location = new Point(16, 18);
            ReportTable.Name = "ReportTable";
            ReportTable.RowHeadersVisible = false;
            ReportTable.RowTemplate.Height = 25;
            ReportTable.ScrollBars = ScrollBars.Vertical;
            ReportTable.Size = new Size(708, 531);
            ReportTable.TabIndex = 4;
            // 
            // DishType
            // 
            DishType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishType.HeaderText = "Tipo de platillo";
            DishType.Name = "DishType";
            DishType.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.HeaderText = "Precio unitario";
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Cantidad";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
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
            ButtonGenerate.Location = new Point(881, 497);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(131, 23);
            ButtonGenerate.TabIndex = 6;
            ButtonGenerate.Text = "Generar reporte";
            ButtonGenerate.UseVisualStyleBackColor = true;
            ButtonGenerate.Click += ButtonGenerate_Click;
            // 
            // ButtonDownloadExcel
            // 
            ButtonDownloadExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonDownloadExcel.Enabled = false;
            ButtonDownloadExcel.Location = new Point(881, 526);
            ButtonDownloadExcel.Name = "ButtonDownloadExcel";
            ButtonDownloadExcel.Size = new Size(131, 23);
            ButtonDownloadExcel.TabIndex = 7;
            ButtonDownloadExcel.Text = "Descargar Excel";
            ButtonDownloadExcel.UseVisualStyleBackColor = true;
            ButtonDownloadExcel.Click += ButtonDownloadExcel_Click;
            // 
            // RangeLabel
            // 
            RangeLabel.AutoSize = true;
            RangeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RangeLabel.Location = new Point(764, 232);
            RangeLabel.Name = "RangeLabel";
            RangeLabel.Size = new Size(0, 15);
            RangeLabel.TabIndex = 8;
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
        private DataGridViewTextBoxColumn DishType;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label RangeLabel;
    }
}
