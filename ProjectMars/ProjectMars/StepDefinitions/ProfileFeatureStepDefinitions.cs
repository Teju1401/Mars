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
        Certifications CertificationsObj = new Certifications();

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
        public void WhenICreateLanguageOnTheProfilePage(string Language1)
        {
            LanguageObj.CreateLanguages(driver, Language1);
        }

        [Then(@"The language record should be able to create '([^']*)'")]
        public void ThenTheLanguageRecordShouldBeAbleToCreate(string Language1)
        {
            string newactualLanguage = LanguageObj.GetactualLanguage(driver);
            Assert.That(newactualLanguage == Language1, "actual Language and expexted Language donot match");
        }
              

        [When(@"I update the languages '([^']*)' on the profile home page")]
        public void WhenIUpdateTheLanguagesOnTheProfileHomePage(string Language2)
        {
            LanguageObj.UpdateLanguages(driver, Language2);
        }

        [Then(@"The language record should be updated with '([^']*)' on th profile home page")]
        public void ThenTheLanguageRecordShouldBeUpdatedWithOnThProfileHomePage(string Language2)
        {
            string newactualupdatedLanguage = LanguageObj.GetactualupdatedLanguage(driver);
            Assert.That(newactualupdatedLanguage == Language2, "actual updated Language and expexted updated Language donot match");
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
        public void WhenICreateSkillsOnTheProfilePage(string skill1)
        {
            SkillsObj.CreateSkills(driver, skill1);
        }

        [Then(@"The skillsrecord should be able to create '([^']*)'")]
        public void ThenTheSkillsrecordShouldBeAbleToCreate(string skill1)
        {
            string newactualskill = SkillsObj.Getactualskill(driver);
            Assert.That(newactualskill == skill1, "actualskill and expexted skill donot match");
        }
                

        [When(@"I update the Skills '([^']*)' on the profile home page")]
        public void WhenIUpdateTheSkillsOnTheProfileHomePage(string Skill2)
        {
            SkillsObj.Updateskills(driver, Skill2);
        }

        [Then(@"The skills record should be updated with '([^']*)' on th profile home page")]
        public void ThenTheSkillsRecordShouldBeUpdatedWithOnThProfileHomePage(string Skill2)
        {
            string newactualupdatedskill = SkillsObj.Getactualupdatedskill(driver);
            Assert.That(newactualupdatedskill == Skill2, "actualskill and expexted skill donot match");
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
        public void WhenICreateCollegeAndDegreeInEducationOnTheProfilePage(string College, string Degree)
        {
            EducationObj.CreateEducation(driver, College, Degree);
        }

        [Then(@"The Education record should be to create '([^']*)','([^']*)'")]
        public void ThenTheEducationRecordShouldBeToCreate(string College, string Degree)
        {
            
            string newuniversity = EducationObj.Getuniversity(driver);
            Assert.That(newuniversity == College, "actual university name and expexted university name donot match");
        }

        [When(@"I update the College and Degree in Education '([^']*)','([^']*)' on the profile home page")]
        public void WhenIUpdateTheCollegeAndDegreeInEducationOnTheProfileHomePage(string College1, string Degree1)
        {
            EducationObj.UpdateEducation(driver, College1, Degree1);
        }

        [Then(@"The Education record should be updated '([^']*)','([^']*)' on th profile home page")]
        public void ThenTheEducationRecordShouldBeUpdatedOnThProfileHomePage(string College1, string Degree1)
        {
            string newUpdateuniversity = EducationObj.GetUpdateuniversity(driver);
            Assert.That(newUpdateuniversity == College1, "actual university name and expexted university name donot match");
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

        [Given(@"I Loggin to the Mars web portal succesfully to create Certifications page")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToCreateCertificationsPage()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [Given(@"I navigate to the profile home page to create Certifications")]
        public void GivenINavigateToTheProfileHomePageToCreateCertifications()
        {
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I create Certificate and certified from in Certifications '([^']*)','([^']*)' on the profile page")]
        public void WhenICreateCertificateAndCertifiedFromInCertificationsOnTheProfilePage(string Certificate, string Certified)
        {
            CertificationsObj.CreateCertifications(driver, Certificate, Certified);
        }

        [Then(@"The Certifications record should be to create '([^']*)','([^']*)'")]
        public void ThenTheCertificationsRecordShouldBeToCreate(string Certificate, string Certified)
        {
            string newCertificationsrecord = CertificationsObj.Getrecord(driver);

            Assert.That(newCertificationsrecord == Certificate, "the record is not created");

                


        }





    }
}
