using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Base
{
    public class WebDriverKeywords
    {

        private IWebDriver driver;
        private DefaultWait<IWebDriver> wait;

        public WebDriverKeywords(IWebDriver driver)
        {
            this.driver = driver;
            
            wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout=TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(Exception));

            //wait.PollingInterval=TimeSpan.FromSeconds(1);
        }

        public void clickElement(By locator)
        {
           // driver.FindElement(locator).Click();
           wait.Until(x=>x.FindElement(locator)).Click();
        }

        public void typeOnElement(By locator, String text)
        {
            //driver.FindElement(locator).Clear();
            //driver.FindElement(locator).SendKeys(text);
            wait.Until(x => x.FindElement(locator)).Clear();
            wait.Until(x => x.FindElement(locator)).SendKeys(text);
        }

        public String getElementText(By locator)
        {
            return driver.FindElement(locator).Text;
        }
    }
}
