using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverLake.HealthRecordAutomation.Utilities
{
    public class ExcelUtils
    {
        /// <summary>
        /// Generic method to convert any sheet into two dimensional array
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sheetname"></param>
        /// <returns></returns>
        public static object[] GetSheetIntoArray(string filePath, string sheetname)
        {
            XLWorkbook book = new XLWorkbook(filePath);
            var sheet = book.Worksheet(sheetname);
            var range = sheet.RangeUsed();
            int rowCount = range.RowCount();
            int columnCount = range.ColumnCount();

            object[] allData = new object[rowCount - 1];
            for (int r = 2; r <= rowCount; r++)
            {
                object[] dataSet = new object[columnCount];
                for (int c = 1; c <= columnCount; c++)
                {
                    dataSet[c - 1] = range.Cell(r, c).GetString();
                }
                allData[r - 2] = dataSet;
            }

            book.Dispose();
            return allData;
        }
    }
}
