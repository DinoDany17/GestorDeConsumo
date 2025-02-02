using GestorDeConsumo.Utils.ExcelTemplates;
using GestorDeConsumo.Database.Models;
using SpreadsheetLight;
using System.Data;

namespace GestorDeConsumo.Controllers
{
    internal class ReportController
    {
        public static void GenerateConsumptionPerDishExcel(ConsumptionReportRow[] rows, string path, string date)
        {
            string template = $"{Environment.GetEnvironmentVariable("APP_DIRECTORY")}Utils\\ExcelTemplates\\ConsumptionPerDish.xlsx";
            using (SLDocument finalDocument = new SLDocument())
            {
                ExcelUtils.CopyTemplate(template, finalDocument);
                finalDocument.SetCellValue("B2", $"Fecha: {DateTime.Today}");

                // Insert data
                for (int i = 0; i < rows.Length; i++)
                {
                    int row = 4 + i;
                    finalDocument.SetCellValue(row, 2, rows[i].dish);
                    finalDocument.SetCellValue(row, 3, rows[i].cost);
                    finalDocument.SetCellValue(row, 4, rows[i].quantity);
                    finalDocument.SetCellValue(row, 5, rows[i].total);
                }


                // Set currency format
                SLStyle style = finalDocument.CreateStyle();
                style.FormatCode = "[$$-en-US]#,##0.00";
                finalDocument.SetCellStyle(4, 3, 4 + rows.Length, 3, style);
                finalDocument.SetCellStyle(4, 5, 4 + rows.Length, 5, style);

                // Insert total formula
                finalDocument.SetCellValue(4 + rows.Length, 4, "Total:");
                finalDocument.SetCellValue(4 + rows.Length, 5, $"=SUM(E4:E{3 + rows.Length})");

                // Set total formula bold
                style = finalDocument.CreateStyle();
                style.Font.Bold = true;
                finalDocument.SetCellStyle(4 + rows.Length, 4, 4 + rows.Length, 5, style);

                // Save the file
                finalDocument.SaveAs(path);
            }
        }
    }
}
