using HealthRecordAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Pages
{
    public class LoginPage : WebDriverKeywords
    {
        private By usernameLocator = By.Id("authUser");
        private By passwordLocator = By.CssSelector("#clearPass");
        private By invalidLocator = By.XPath("//p[contains(text(),'Invalid')]");
        private By loginLocator = By.CssSelector("#login-button");

        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver):base(driver) 
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(loginLocator).Click();
        }

    }
}
