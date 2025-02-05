using DocumentFormat.OpenXml.Spreadsheet;
using GestorDeConsumo.Database.Models;
using SpreadsheetLight;

namespace GestorDeConsumo.Controllers
{
    internal class ReportController
    {
        public static void GenerateConsumptionPerDishExcel(ConsumptionReportRow[] rows, string path, string date)
        {
            using (SLDocument finalDocument = new SLDocument())
            {
                // Set header style
                finalDocument.SetColumnWidth(2, 2, 40);
                finalDocument.SetColumnWidth(3, 3, 20);
                finalDocument.SetColumnWidth(4, 4, 20);
                finalDocument.SetColumnWidth(5, 5, 20);
                finalDocument.MergeWorksheetCells("A1", "F1");
                finalDocument.MergeWorksheetCells("B2", "E2");
                SLStyle headerStyle = finalDocument.CreateStyle();
                headerStyle.SetFont("Arial", 20);
                headerStyle.Font.Bold = true;
                headerStyle.Border.Outline = true;
                headerStyle.Border.SetBottomBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                headerStyle.Border.SetTopBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                headerStyle.Border.SetLeftBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                headerStyle.Border.SetRightBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                headerStyle.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.DarkCyan, System.Drawing.Color.DarkCyan);
                headerStyle.SetHorizontalAlignment(HorizontalAlignmentValues.Center);
                finalDocument.SetCellStyle("A1", headerStyle);
                finalDocument.SetCellStyle("B1", headerStyle);
                finalDocument.SetCellStyle("C1", headerStyle);
                finalDocument.SetCellStyle("D1", headerStyle);
                finalDocument.SetCellStyle("E1", headerStyle);
                finalDocument.SetCellStyle("F1", headerStyle);
                SLStyle dateStyle = finalDocument.CreateStyle();
                dateStyle.SetFont("Arial", 12);
                dateStyle.Font.Bold = true;
                dateStyle.Border.SetBottomBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                dateStyle.Border.SetTopBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                dateStyle.Border.SetLeftBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                dateStyle.Border.SetRightBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                dateStyle.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightGray, System.Drawing.Color.LightGray);
                dateStyle.SetHorizontalAlignment(HorizontalAlignmentValues.Center);
                finalDocument.SetCellStyle("B2", dateStyle);
                finalDocument.SetCellStyle("C2", dateStyle);
                finalDocument.SetCellStyle("D2", dateStyle);
                finalDocument.SetCellStyle("E2", dateStyle);
                SLStyle columnHeaderStyle = finalDocument.CreateStyle();
                columnHeaderStyle.Font.Bold = true;
                columnHeaderStyle.Border.SetBottomBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                columnHeaderStyle.Border.SetTopBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                columnHeaderStyle.Border.SetLeftBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                columnHeaderStyle.Border.SetRightBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
                columnHeaderStyle.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.LightBlue, System.Drawing.Color.LightBlue);
                columnHeaderStyle.SetHorizontalAlignment(HorizontalAlignmentValues.Center);
                finalDocument.SetCellStyle("B3", columnHeaderStyle);
                finalDocument.SetCellStyle("C3", columnHeaderStyle);
                finalDocument.SetCellStyle("D3", columnHeaderStyle);
                finalDocument.SetCellStyle("E3", columnHeaderStyle);

                // Set Document header
                finalDocument.SetCellValue("A1", "Reporte de consumo");
                finalDocument.SetCellValue("B2", $"Fecha: {DateTime.Today}");
                finalDocument.SetCellValue("B3", "Platillo");
                finalDocument.SetCellValue("C3", "Costo Unitario");
                finalDocument.SetCellValue("D3", "Cantidad");
                finalDocument.SetCellValue("E3", "Total");

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
