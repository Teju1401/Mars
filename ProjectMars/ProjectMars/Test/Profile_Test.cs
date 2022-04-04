using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Pages;
using ProjectMars.Profile;
using ProjectMars.Utilities;
using System;
using System.Threading;

namespace ProjectMars.Pages

{
    [TestFixture]

    internal class Profil_Test:CommonDriver 
    {

        [SetUp]
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
         [Test]
         public void AddLanguages_Profile_Test()
         {
            // Add Language on profile page

            Languages LanguageObj = new Languages();
            LanguageObj.AddLanguages(driver);




         }
         [Test]
         public void EditLanguages_Profile_Test()
         {
            //Edit Language on profile page

            Languages LanguageObj = new Languages();
            LanguageObj.EditLanguages(driver);


         }
         [Test]
         public void DeleteLanguages_Profile_Test()
         {

            // Delete Language on profile page

            Languages LanguageObj = new Languages();
            LanguageObj.DeleteLanguages(driver);


         }
         [Test]
         public void AddSkills_Profile_Test()
         {
            // Add Skills on profile page

            Skills SkillsObj = new Skills();
            SkillsObj.AddSkills(driver);


         }
         [Test]
         public void EditSkills_Profile_Test()
         {
            // Edit Skills on profile page 
            Skills SkillsObj = new Skills();
            SkillsObj.Editskills(driver);



         }
         [Test]
         public void DeleteSkills_Profile_Test()
         {
            // Delete Skills on profile page 

            Skills SkillsObj = new Skills();
            SkillsObj.Deleteskills(driver);



         }
         [Test]
         public void AddEducation_Profile_Test()
         {

            //Add Education on profile page 

            Education EducationObj = new Education();
            EducationObj.AddEducation(driver);





         }
         [Test]
         public void EditEducation_Profile_Test()
         {
            //Edit Education on profile page 
            Education EducationObj = new Education();
            EducationObj.EditEducation(driver);



         }
         [Test]
         public void DeleteEducation_Profile_Test()
         {
            Education EducationObj = new Education();
            EducationObj.DeleteEducation(driver);

         }
        [TearDown]
         public void closetestrun()
         {
            driver.Quit();           

         }



       
    }
}
