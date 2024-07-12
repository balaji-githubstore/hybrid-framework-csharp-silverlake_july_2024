using HealthRecordAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Pages
{
    /// <summary>
    /// All common web elements and menu will be handled here. 
    /// </summary>
    public class MainPage : WebDriverKeywords
    {
        private readonly IWebDriver driver;

        public MainPage(IWebDriver driver):base(driver) 
        {
            this.driver = driver;
        }

        //public string GetMainPageTitle()
        //{
        //    return driver.Title;
        //}

        public string MainPageTitle
        {
            get {  return driver.Title; }
        }

    }
}
