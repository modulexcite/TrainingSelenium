using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Alwin
{
    public class RegisterPage
    {
        private IWebDriver _driver;

        public RegisterPage(IWebDriver driver, string url)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(url);

        }

        public void EnterUserName(string userName)
        {
            _driver.FindElement(By.Id("MainContent_RegisterUser_CreateUserStepContainer_UserName")).SendKeys(userName);
        }
    }
}
