using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Profile
{
    internal class Profile_Test: CommonDriver

    {
        
        public void LoginFunction()
        {
            // open chrome driver

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object Initialization and definition
            

            LoginPage loginpageObj = new LoginPage();
            loginpageObj.Loginsteps(driver);

            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);




        }

        public void EditLanguages()
        {



        }

        public void EditSkills()
        {



        }

        public void EditEducation()
        {

        }

        public void EditCertifications()
        {


        }

























    }
}
