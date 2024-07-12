using DocumentFormat.OpenXml.Spreadsheet;
using HealthRecordAutomation.Pages;
using OpenQA.Selenium;
using SilverLake.HealthRecordAutomation.Base;
using SilverLake.HealthRecordAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverLake.HealthRecordAutomation.Test
{
    public class LoginTest : AutomationWrapper
    {

        [TestCase("admin", "pass", "OpenEMR")]
        [TestCase("receptionist", "receptionist", "OpenEMR")]
        public void ValidLoginTest1(string username, string password, string expectedTitle)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            MainPage main= new MainPage(driver);
            Assert.That(main.MainPageTitle, Is.EqualTo(expectedTitle));
        }

        [Test, TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginDataExcel))]
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username);
            login.EnterPassword(password);
            login.ClickOnLogin();

            MainPage main = new MainPage(driver);
            Assert.That(main.MainPageTitle, Is.EqualTo(expectedTitle));
        }
    }
}
