using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace HealthRecordAutomation.Test
{
    /// <summary>
    /// No need to do 
    /// will be deleted
    /// </summary>
    public class ZDemoTest
    {
        [Test]
        public void ReadExcel()
        {
            string excelPath = TestContext.CurrentContext.TestDirectory.Split("bin")[0] + @"\TestData\open_emr_data.xlsx"; ;

            Console.WriteLine(excelPath);
            // XLWorkbook book = new XLWorkbook(@"C:\Mine\Company\Sileverlake Malaysia July 2024\AutomationFrameworkSolution\HealthRecordAutomation\TestData\open_emr_data.xlsx");
            XLWorkbook book = new XLWorkbook(excelPath);

            var sheet =  book.Worksheet("validLoginTest");

            var range=sheet.RangeUsed();
            int rowCount = range.RowCount();
            int columnCount = range.ColumnCount();

            object[] allData = new object[rowCount-1];

            for (int r = 2; r <= rowCount; r++)
            {
                object[] dataSet = new object[columnCount];
                for(int c = 1;c <= columnCount; c++)
                {
                    dataSet[c-1] = range.Cell(r, c).GetString(); 
                }
                allData[r-2] = dataSet;
            }

            book.Dispose();
        }
    }
}
