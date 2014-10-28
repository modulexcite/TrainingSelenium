using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alwin
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://fourthqaportal.cloudapp.net/technicaltest/Account/Register");
            driver.FindElement(By.Id("MainContent_RegisterUser_CreateUserStepContainer_UserName")).SendKeys("user_name");
            driver.FindElement(By.Id("MainContent_RegisterUser_CreateUserStepContainer_Email")).SendKeys("user@fourthdev.com");
            driver.FindElement(By.Id("MainContent_RegisterUser_CreateUserStepContainer_Password")).SendKeys("password");
            driver.FindElement(By.Id("MainContent_RegisterUser_CreateUserStepContainer_ConfirmPassword")).SendKeys("password");
            driver.FindElement(By.Name("ctl00$MainContent$RegisterUser$CreateUserStepContainer$ctl09")).Click();
        }

        [Test]
        public void TestTwo()
        {
            IWebDriver driver = new ChromeDriver();
            RegisterPage registerPage = new RegisterPage(driver, "http://fourthqaportal.cloudapp.net/technicaltest/Account/Register");
            registerPage.EnterUserName("AUser");
        }
    }
}
