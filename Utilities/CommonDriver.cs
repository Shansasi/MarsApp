using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Mars.Pages;
using NUnit.Framework;

namespace Mars.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }
        public void CloseTestRun()
        {
            //driver.Close();
            driver.Quit();
        }

    }
}
