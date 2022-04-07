using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Profile;
using ProjectMars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginpageObj = new LoginPage();
        HomePage homepageObj = new HomePage();

        Languages LanguageObj = new Languages();
        Skills SkillsObj = new Skills();
        Education EducationObj = new Education();

        [Given(@"Loggin to the Mars web portal with valid credentials")]
        public void GivenLogginToTheMarsWebPortalWithValidCredentials()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [Given(@"I navigated to the profile home page")]
        public void GivenINavigatedToTheProfileHomePage()
        {
            
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I click on the Profile home page")]
        public void WhenIClickOnTheProfileHomePage()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }

        [Then(@"I could see the profile name")]
        public void ThenICouldSeeTheProfileName()
        {
            string newactualname = homepageObj.Getactualname(driver);
            Assert.That(newactualname == "Hi Teja Kumari", "actual name and expected name donot match");
        }

        [Given(@"I Loggin to the Mars web portal succesfully with valid credentials to perform CRUD")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyWithValidCredentialsToPerformCRUD()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [Given(@"I navigated to the profile home page to perform CRUD for languages")]
        public void GivenINavigatedToTheProfileHomePageToPerformCRUDForLanguages()
        {
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I create language '([^']*)' on the profile page")]
        public void WhenICreateLanguageOnTheProfilePage(string english)
        {
            LanguageObj.CreateLanguages(driver, english);
        }

        [Then(@"The language record should be able to create '([^']*)'")]
        public void ThenTheLanguageRecordShouldBeAbleToCreate(string english)
        {
            string newactualLanguage = LanguageObj.GetactualLanguage(driver);
            Assert.That(newactualLanguage == english, "actual Language and expexted Language donot match");
        }
              

        [When(@"I update the languages '([^']*)' on the profile home page")]
        public void WhenIUpdateTheLanguagesOnTheProfileHomePage(string hindi)
        {
            LanguageObj.UpdateLanguages(driver, hindi);
        }

        [Then(@"The language record should be updated with '([^']*)' on th profile home page")]
        public void ThenTheLanguageRecordShouldBeUpdatedWithOnThProfileHomePage(string hindi)
        {
            string newactualupdatedLanguage = LanguageObj.GetactualupdatedLanguage(driver);
            Assert.That(newactualupdatedLanguage == hindi, "actual updated Language and expexted updated Language donot match");
        }

        [When(@"I delete the Languages on the profile home page")]
        public void WhenIDeleteTheLanguagesOnTheProfileHomePage()
        {
            LanguageObj.DeleteLanguages(driver);
        }

        [Then(@"the language record should be deleted on the profile home page")]
        public void ThenTheLanguageRecordShouldBeDeletedOnTheProfileHomePage()
        {
            string newupdatedrecord = LanguageObj.GetDeletedRecord(driver);
            Assert.That(newupdatedrecord != "English", " record is not deleted");
        }

        [Given(@"I Loggin to the Mars web portal succesfully to perform CRUD for skills")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToPerformCRUDForSkills()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [Given(@"I navigate to the profile home page to perform CRUD for skills")]
        public void GivenINavigateToTheProfileHomePageToPerformCRUDForSkills()
        {
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I create Skills '([^']*)' on the profile page")]
        public void WhenICreateSkillsOnTheProfilePage(string painting)
        {
            SkillsObj.CreateSkills(driver, painting);
        }

        [Then(@"The skillsrecord should be able to create '([^']*)'")]
        public void ThenTheSkillsrecordShouldBeAbleToCreate(string painting)
        {
            string newactualskill = SkillsObj.Getactualskill(driver);
            Assert.That(newactualskill == painting, "actualskill and expexted skill donot match");
        }
                

        [When(@"I update the Skills '([^']*)' on the profile home page")]
        public void WhenIUpdateTheSkillsOnTheProfileHomePage(string dancing)
        {
            SkillsObj.Updateskills(driver, dancing);
        }

        [Then(@"The skills record should be updated with '([^']*)' on th profile home page")]
        public void ThenTheSkillsRecordShouldBeUpdatedWithOnThProfileHomePage(string dancing)
        {
            string newactualupdatedskill = SkillsObj.Getactualupdatedskill(driver);
            Assert.That(newactualupdatedskill == dancing, "actualskill and expexted skill donot match");
        }
               

        [When(@"I delete the Skills on the profile home page")]
        public void WhenIDeleteTheSkillsOnTheProfileHomePage()
        {
            SkillsObj.Deleteskills(driver);
        }

        [Then(@"the Skills record should be deleted on the profile home page")]
        public void ThenTheSkillsRecordShouldBeDeletedOnTheProfileHomePage()
        {
            string newActualskillname = SkillsObj.GetDeletedskillsrecord(driver);
            Assert.That(newActualskillname != "Cricket", "skill record is not deleted");
        }

        [Given(@"I Loggin to the Mars web portal succesfully to perform CRUD for Education")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToPerformCRUDForEducation()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [Given(@"I navigate to the profile home page to perform CRUD for Education")]
        public void GivenINavigateToTheProfileHomePageToPerformCRUDForEducation()
        {
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I create College and Degree in Education '([^']*)','([^']*)' on the profile page")]
        public void WhenICreateCollegeAndDegreeInEducationOnTheProfilePage(string aBC, string p1)
        {
            EducationObj.CreateEducation(driver, aBC, p1);
        }

        [Then(@"The Education record should be to create '([^']*)','([^']*)'")]
        public void ThenTheEducationRecordShouldBeToCreate(string aBC, string p1)
        {
            
            string newuniversity = EducationObj.Getuniversity(driver);
            Assert.That(newuniversity == aBC, "actual university name and expexted university name donot match");
        }

        [When(@"I update the College and Degree in Education '([^']*)','([^']*)' on the profile home page")]
        public void WhenIUpdateTheCollegeAndDegreeInEducationOnTheProfileHomePage(string qWERTY, string begginer)
        {
            EducationObj.UpdateEducation(driver, qWERTY, begginer);
        }

        [Then(@"The Education record should be updated '([^']*)','([^']*)' on th profile home page")]
        public void ThenTheEducationRecordShouldBeUpdatedOnThProfileHomePage(string qWERTY, string begginer)
        {
            string newUpdateuniversity = EducationObj.GetUpdateuniversity(driver);
            Assert.That(newUpdateuniversity == qWERTY, "actual university name and expexted university name donot match");
        }

        [When(@"I delete the Education on the profile home page")]
        public void WhenIDeleteTheEducationOnTheProfileHomePage()
        {
            EducationObj.DeleteEducation(driver);
        }

        [Then(@"the Education record should be deleted on the profile home page")]
        public void ThenTheEducationRecordShouldBeDeletedOnTheProfileHomePage()
        {
            string newEducationrecord = EducationObj.GetDeletededucationrecord(driver);
            Assert.That(newEducationrecord != "QWERTY", "record is not deleted");

        }


        

    }
}
