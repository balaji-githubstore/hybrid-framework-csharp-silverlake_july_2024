using HealthRecordAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Pages
{
    public class SearchOrAddPatientPage : WebDriverKeywords
    {
        private readonly IWebDriver driver;

        public SearchOrAddPatientPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }
    }
}
