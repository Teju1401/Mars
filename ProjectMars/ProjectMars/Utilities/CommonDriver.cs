using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Utilities
{
    public class CommonDriver
    {

        public IWebDriver driver;

        [OneTimeSetUp]
        public void loginFunction()
        {
            // launch chrome driver

            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            // Login page object initialization and definition

            LoginPage loginpageObj = new LoginPage();
            loginpageObj.Loginsteps(driver);



        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
        



















    }
}
