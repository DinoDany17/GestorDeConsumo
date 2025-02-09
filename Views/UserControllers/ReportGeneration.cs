using GestorDeConsumo.Controllers;
using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Views.UserControllers.MessageBoxes;

namespace GestorDeConsumo.Views.UserControllers
{
    public partial class ReportGeneration : UserControl
    {
        ConsumptionReportRow[] currentReport = new ConsumptionReportRow[0];
        public ReportGeneration()
        {
            InitializeComponent();
        }

        private void ReportGeneration_Load(object sender, EventArgs e)
        {
            RangeLabel.Text = $"De {RangeCalendar.SelectionStart.ToString("yyyy-MM-dd")} a {RangeCalendar.SelectionEnd.ToString("yyyy-MM-dd")}";
            RangeCalendar.MaxDate = DateTime.Today;
            RangeCalendar.SelectionStart = DateTime.Today;
            RangeCalendar.SelectionEnd = DateTime.Today;
        }

        private void RangeCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            RangeLabel.Text = $"De {RangeCalendar.SelectionStart.ToString("yyyy-MM-dd")} a {RangeCalendar.SelectionEnd.ToString("yyyy-MM-dd")}";
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            // Clear ReportTable
            ReportTable.Rows.Clear();
            // Get selected range
            DateTime startDay = RangeCalendar.SelectionStart;
            DateTime endDay = RangeCalendar.SelectionEnd;
            // Generate report
            currentReport = ConsumptionController.GetConsumptionReport(startDay, endDay);
            // Fill ReportTable
            if (currentReport.Length > 0)
            {
                foreach (ConsumptionReportRow row in currentReport)
                {
                    ReportTable.Rows.Add(row.emp_name, row.emp_number, row.dish, row.quantity, row.total);
                }
                ButtonDownloadExcel.Enabled = true;
            }
        }

        private void ButtonDownloadExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DateTime startDay = RangeCalendar.SelectionStart;
                DateTime endDay = RangeCalendar.SelectionEnd;
                string range = $"De {startDay.ToString("yyyy/MM/dd")} a {endDay.ToString("yyyy/MM/dd")}";
                ReportController.GenerateConsumptionPerDishExcel(currentReport, filePath, range);
            }
            else
            {
                CustomMessageBox.Show("No se seleccionó ninguna ruta", CustomMessageBoxType.Warning);
            }
        }

        private void ReportTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            }
            if (e.ColumnIndex == 4)
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            }
            if (e.RowIndex == -1)
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        public void ClearControl()
        {
            ReportTable.Rows.Clear();
            ButtonDownloadExcel.Enabled = false;
        }
    }
}
