using NUnit.Framework;
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
    [TestFixture]
    [Parallelizable]
    internal class Test_Profile : CommonDriver

    {
        [Test, Order(1)]
        public void CreateLanguages_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            // Add Language on profile page

            Languages LanguageObj = new Languages();
            LanguageObj.CreateLanguages(driver, "english");

        }
        [Test, Order(2)]
        public void UpdateLanguages_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Languages LanguageObj = new Languages();
            LanguageObj.UpdateLanguages(driver, "hindi");
                
        }
        [Test, Order(3)]
        public void DeleteLanguages_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Languages LanguageObj = new Languages();
            LanguageObj.DeleteLanguages(driver);
        }
        [Test, Order(4)]
        public void CreateSkills_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Skills SkillsObj = new Skills();
            SkillsObj.CreateSkills(driver, "painting");


        }
        [Test, Order(5)]
        public void UpdateSkills_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Skills SkillsObj = new Skills();
            SkillsObj.Updateskills(driver, "dancing");
        }
        [Test, Order(6)]
        public void DeleteSkills_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Skills SkillsObj = new Skills();
            SkillsObj.Deleteskills(driver);

        }
        [Test, Order(7)]
        public void CreateEducation_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);


            Education EducationObj = new Education();
            EducationObj.CreateEducation(driver, "aBC", "p1");
        }
        [Test, Order(8)]
        public void UpdateEducation_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Education EducationObj = new Education();
            EducationObj.UpdateEducation(driver, "qWERTY", "begginer");

        }
        [Test, Order(9)]
        public void DeleteEducation_Test_Profile()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);

            Education EducationObj = new Education();
            EducationObj.DeleteEducation(driver);
        }






    }
}
