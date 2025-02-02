using SpreadsheetLight;

namespace GestorDeConsumo.Utils.ExcelTemplates
{
    internal class ExcelUtils
    {
        public static void CopyTemplate(string templatePath, SLDocument destinyDocument)
        {
            FileStream fs = new FileStream(templatePath, FileMode.Open);
            SLDocument templateDocument = new SLDocument(fs);
            string[] sheetNames = templateDocument.GetSheetNames().ToArray();
            foreach (string sheetName in sheetNames)
            {
                templateDocument.SelectWorksheet(sheetName);
                destinyDocument.AddWorksheet(sheetName);
                destinyDocument.SelectWorksheet(sheetName);
                SLWorksheetStatistics stats = templateDocument.GetWorksheetStatistics();
                for (int i = 1; i <= stats.EndColumnIndex; i++)
                {
                    destinyDocument.SetColumnWidth(i, templateDocument.GetColumnWidth(i));
                    for (int j = 1; j <= stats.EndRowIndex; j++)
                    {
                        destinyDocument.SetCellValue(j, i, templateDocument.GetCellValueAsString(j, i));
                        destinyDocument.SetCellStyle(j, i, templateDocument.GetCellStyle(j, i));
                    }
                }
                SLMergeCell[] mergedCells = templateDocument.GetWorksheetMergeCells().ToArray();
                foreach(SLMergeCell mergedCell in mergedCells)
                {
                    destinyDocument.MergeWorksheetCells(mergedCell.StartRowIndex, mergedCell.StartColumnIndex, mergedCell.EndRowIndex, mergedCell.EndColumnIndex);
                }
            }
            fs.Close();
        }
    }
}
