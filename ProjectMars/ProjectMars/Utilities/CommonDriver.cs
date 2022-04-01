using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Utilities
{
    internal class CommonDriver
    {

        public static IWebDriver driver;

        public void loginFunction()
        {
            // launch chrome driver

            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            // Login page object initialization and definition

            



        }
        



















    }
}
