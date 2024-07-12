using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(By.CssSelector("#login-button")).Click();
        }

    }
}
