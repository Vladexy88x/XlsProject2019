using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using FreelanceProj1.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelanceProj1.XlsWork
{
    class XlsWorker
    {
        #region EditTableXslsWork
        //private void EditTableXlsx(string fileName)
        //{
        //    if(fileName == null)
        //    {
        //        MessageBox.Show("Файл не выбран.Выберите файл");
        //        return;
        //    }

        //    using (SpreadsheetDocument spreadDoc = SpreadsheetDocument.Create(fileName, SpreadsheetDocumentType.Workbook))
        //    {
        //        WorkbookPart workbookPart = spreadDoc.AddWorkbookPart();
        //        workbookPart.Workbook = new Workbook();
        //        WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

        //        FileVersion versionFile = new FileVersion();
        //        versionFile.ApplicationName = "Microsoft Office Excel";
        //        worksheetPart.Worksheet = new Worksheet(new SheetData());

        //        WorkbookStylesPart wbsp = workbookPart.AddNewPart<WorkbookStylesPart>();

        //        Columns columns = worksheetPart.Worksheet.GetFirstChild<Columns>();
        //        bool isInsert = false;

        //        if (columns == null)
        //        {
        //            columns = new Columns();
        //            isInsert = true;
        //        }

        //        columns.Append(new Column { Min = 1, Max = 5, Width = 5, CustomWidth = true });
        //        columns.Append(new Column { Min = 2, Max = 5, Width = 5, CustomWidth = true });
        //        if (isInsert)
        //            worksheetPart.Worksheet.InsertAt(columns, 0);

        //        Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
        //        Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet11" };
        //        sheets.Append(sheet);

        //        SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

        //        //Добавим заголовки в первую строку
        //        Row row = new Row() { RowIndex = 1 };
        //        sheetData.Append(row);

        //        InsertCell(row, 1, "Стиль 1", CellValues.String, 5);
        //        InsertCell(row, 2, "Стиль 2", CellValues.String, 5);

        //        // Добавляем в строку все стили подряд.
        //        row = new Row() { RowIndex = 6 };
        //        sheetData.Append(row);

        //        //InsertCell(row, 1, "1text", CellValues.String, 1);
        //        //InsertCell(row, 2, "textF", CellValues.String, 2);

        //        for (int i = 0; i < listParseAll.Count; i++)
        //        {
        //            InsertCell(row, i, listParseAll[i].ToString(), CellValues.String, 5);
        //        }

        //        workbookPart.Workbook.Save();
        //        spreadDoc.Close();

        //    }

        //}
        #endregion

        #region InsertCell
        //private void InsertCell(Row row, int cell_num, string val, CellValues type, uint styleIndex)
        //{
        //    Cell refCell = null;
        //    Cell newCell = new Cell() { CellReference = cell_num.ToString() + ":" + row.RowIndex.ToString(), StyleIndex = styleIndex };
        //    row.InsertBefore(newCell, refCell);

        //    // Устанавливает тип значения.
        //    newCell.CellValue = new CellValue(val);
        //    newCell.DataType = new EnumValue<CellValues>(type);

        //}
        #endregion

        public void WriteDataXlsx()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("sheetName");
                worksheet.Cell("A5").Value = "Hello CloseXML";
                worksheet.Cell("B3").Value = "Hello B3";
                worksheet.Cell("B4").Value = 979;
                workbook.SaveAs("helloCloseXML.xlsx");
            }
        }

        public void WriteDataXlsxBeta(ListBox listBox, string uriInput)
        {
            ParseWork parseWork = new ParseWork();

            XLWorkbook workbook = new XLWorkbook();
            var editWorkSheet = workbook.Worksheets.Add("sheetName");
            var listCountResult = parseWork.ParseTag(listBox, uriInput);
            //object resSrt = null;

            #region OtherAlgo

            //for (int i = 0; i < listCountResult.Count; i++)
            //{
            //    string resultRelease = listCountResult[i];
            //    editWorkSheet.Cell($"A{listCountResult.Count}").Value = resultRelease;
            //}

            //Experimintal
            //var editWorkSheetFix = listCountResult.Where(x => x.ToString() != "").Select(x => x);
            #endregion

            if (listCountResult.Where(c => c.ToString() != "") is var f) 
            {
                foreach (var itemStr in f)
                {
                    editWorkSheet.Cell($"A{itemStr.Count()}").Value = itemStr;
                }
            }
            
            #region DebugAlgo
            //foreach (var itemStr in listCountResult)
            //{
            //    listBox.Items.Add(itemStr);
            //    try
            //    {
            //        /*resSrt =*/ editWorkSheet.Cell($"A{itemStr.Count()}").Value = itemStr;
            //    }
            //    catch (Exception ssae)
            //    {

            //        MessageBox.Show("Detect crash " + ssae.ToString());
            //    }
            //    finally
            //    {
            //        listBox.Items.Add(itemStr);
            //    }

            //}
            #endregion

            workbook.SaveAs("helloCloseXML.xlsx");
            workbook.Dispose();

            
        }

        public void ReadDataXlsx()
        {
            using (var workbook = new XLWorkbook(@""))
            {
                var loadWorkSheet = workbook.Worksheet("sheetName");
                string a = loadWorkSheet.Cell("A5").GetString();
                string b = loadWorkSheet.Cell("B3").GetString();
                string ba = loadWorkSheet.Cell("B4").GetString();
                MessageBox.Show(a);
                MessageBox.Show(b);
                MessageBox.Show(ba);
            }

           
        }

        protected void GetResultParse(ListBox box, string uriSiteTarget, string pathFile)
        {
           // ParseWork parseWork = new ParseWork();

           
        } 
    }
}
