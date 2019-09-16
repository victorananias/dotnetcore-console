using System.IO;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Classes
{
    class Spreadsheet
    {   

        public Spreadsheet()
        {

        }
        public string Import (string filePath)
        {

            HSSFWorkbook workbook;
            
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                workbook = new HSSFWorkbook(file);
            }

        
            // if (file.Length > 0) {
            //     string sFileExtension = Path.GetExtension (file.FileName).ToLower ();
            //     ISheet sheet;
            //     string fullPath = Path.Combine (newPath, file.FileName);
            //     using (var stream = new FileStream (fullPath, FileMode.Create)) {
            //         file.CopyTo (stream);
            //         stream.Position = 0;
            //         if (sFileExtension == ".xls") {
            //             HSSFWorkbook hssfwb = new HSSFWorkbook (stream); //This will read the Excel 97-2000 formats  
            //             sheet = hssfwb.GetSheetAt (0); //get first sheet from workbook  
            //         } else {
            //             XSSFWorkbook hssfwb = new XSSFWorkbook (stream); //This will read 2007 Excel format  
            //             sheet = hssfwb.GetSheetAt (0); //get first sheet from workbook   
            //         }
            //         IRow headerRow = sheet.GetRow (0); //Get Header Row
            //         int cellCount = headerRow.LastCellNum;
            //         sb.Append ("<table class='table'><tr>");
            //         for (int j = 0; j < cellCount; j++) {
            //             NPOI.SS.UserModel.ICell cell = headerRow.GetCell (j);
            //             if (cell == null || string.IsNullOrWhiteSpace (cell.ToString ())) continue;
            //             sb.Append ("<th>" + cell.ToString () + "</th>");
            //         }
            //         sb.Append ("</tr>");
            //         sb.AppendLine ("<tr>");
            //         for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
            //         {
            //             IRow row = sheet.GetRow (i);
            //             if (row == null) continue;
            //             if (row.Cells.All (d => d.CellType == CellType.Blank)) continue;
            //             for (int j = row.FirstCellNum; j < cellCount; j++) {
            //                 if (row.GetCell (j) != null)
            //                     sb.Append ("<td>" + row.GetCell (j).ToString () + "</td>");
            //             }
            //             sb.AppendLine ("</tr>");
            //         }
            //         sb.Append ("</table>");
            //     }
            // }
            // return sb.ToString ();
        }
    }
}