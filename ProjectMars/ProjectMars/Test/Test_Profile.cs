using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Profile;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Test
{
    internal class Test_Profile : CommonDriver

    {
         public static void Main(string[] args)
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

            // Add Language on profile page

            Languages LanguageObj = new Languages();
            LanguageObj.CreateLanguages(driver);

            //Edit Language on profile page

            
            LanguageObj.UpdateLanguages(driver);

            // Delete Language on profile page

            
            LanguageObj.DeleteLanguages(driver);



            Skills SkillsObj = new Skills();
            SkillsObj.CreateSkills(driver);

            SkillsObj.Updateskills(driver);
                     
            SkillsObj.Deleteskills(driver);


            Education EducationObj = new Education();
            EducationObj.CreateEducation(driver);



            EducationObj.UpdateEducation(driver);


            EducationObj.DeleteEducation(driver);








         }






    }
}
