using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverLake.HealthRecordAutomation.Utilities
{
    public class DataSource
    {
        public static object[] ValidLoginDataExcel()
        {
            string excelPath = TestContext.CurrentContext.TestDirectory.Split("bin")[0] + @"\TestData\open_emr_data.xlsx"; 
            object[] arr = ExcelUtils.GetSheetIntoArray(excelPath, "ValidLoginTest");
            return arr;
        }

        public static object[] ValidLoginData()
        {
            //number of parameters
            string[] dataset1 = new string[3];
            dataset1[0] = "admin";
            dataset1[1] = "pass";
            dataset1[2] = "OpenEMR";

            //number of parameters
            string[] dataset2 = new string[3];
            dataset2[0] = "accountant";
            dataset2[1] = "accountant";
            dataset2[2] = "OpenEMR";

            //number of testcases
            object[] allData = new object[2];
            allData[0] = dataset1;
            allData[1] = dataset2;

            return allData;
        }

    }
}
