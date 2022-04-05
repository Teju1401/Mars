using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions
    {
        [Given(@"Loggin to the Mars web portal with valid credentials")]
        public void GivenLogginToTheMarsWebPortalWithValidCredentials()
        {
            // open chrome driver

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object Initialization and definition


            LoginPage loginpageObj = new LoginPage();
            loginpageObj.Loginsteps(driver);

        }

        [Given(@"I navigated to the profile home page")]
        public void GivenINavigatedToTheProfileHomePage()
        {
            //home page object initialization and definition
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I click on the Profile home page")]
        public void WhenIClickOnTheProfileHomePage()
        {
            
        }

        [Then(@"I could see the profile name")]
        public void ThenICouldSeeTheProfileName()
        {
            
        }

        [Given(@"I Loggin to the Mars web portal succesfully")]
        public void GivenILogginToTheMarsWebPortalSuccesfully()
        {
           
        }

        [When(@"I create languages '([^']*)' on the profile page")]
        public void WhenICreateLanguagesOnTheProfilePage(string L0)
        {
            // Add Language on profile page

            Languages LanguageObj = new Languages();
            LanguageObj.CreateLanguages(driver);
        }

        [Then(@"the record should be created '([^']*)'")]
        public void ThenTheRecordShouldBeCreated(string LO)
        {
            
        }

        [When(@"I update languages '([^']*)' on the profile page")]
        public void WhenIUpdateLanguagesOnTheProfilePage(string L1)
        {
            //Edit Language on profile page


            LanguageObj.UpdateLanguages(driver);
        }

        [Then(@"I could see the updated language record '([^']*)'")]
        public void ThenICouldSeeTheUpdatedLanguageRecord(string L1)
        {
            
        }

        [When(@"I Delete languages on the profile page")]
        public void WhenIDeleteLanguagesOnTheProfilePage()
        {
            // Delete Language on profile page


            LanguageObj.DeleteLanguages(driver);
        }

        [Then(@"the record should be deleted")]
        public void ThenTheRecordShouldBeDeleted()
        {
            
        }

        [Given(@"I navigate to the profile home page")]
        public void GivenINavigateToTheProfileHomePage()
        {
            
        }

        [When(@"I create Skills '([^']*)' on the profile page")]
        public void WhenICreateSkillsOnTheProfilePage(string S0)
        {
            Skills SkillsObj = new Skills();
            SkillsObj.CreateSkills(driver);
        }

        [Then(@"I could see the created '([^']*)'")]
        public void ThenICouldSeeTheCreated(string S0)
        {
            
        }

        [Given(@"I navigated to profile home page")]
        public void GivenINavigatedToProfileHomePage()
        {
           
        }

        [When(@"I update the Skills '([^']*)' on the profile page")]
        public void WhenIUpdateTheSkillsOnTheProfilePage(string S1)
        {
            SkillsObj.Updateskills(driver);
        }

        [Then(@"I could see the updated skills record '([^']*)'")]
        public void ThenICouldSeeTheUpdatedSkillsRecord(string S1)
        {
            
        }

        [When(@"I Delete Skills on the profile page")]
        public void WhenIDeleteSkillsOnTheProfilePage()
        {
            SkillsObj.Deleteskills(driver);
        }

        [Then(@"the Skills record should be deleted")]
        public void ThenTheSkillsRecordShouldBeDeleted()
        {
           
        }

        [When(@"I create the College and Degree '([^']*)','([^']*)' on the profile page")]
        public void WhenICreateTheCollegeAndDegreeOnTheProfilePage(string C0, string D0)
        {
            Education EducationObj = new Education();
            EducationObj.CreateEducation(driver);
        }

        [Then(@"I could see the created'([^']*)','([^']*)'")]
        public void ThenICouldSeeTheCreated(string C0, string D0)
        {
           
        }

        [When(@"I update the College and Degree '([^']*)','([^']*)' on the profile page")]
        public void WhenIUpdateTheCollegeAndDegreeOnTheProfilePage(string C1, string D1)
        {
            EducationObj.UpdateEducation(driver);
        }

        [Then(@"I could see the updated education record '([^']*)','([^']*)'")]
        public void ThenICouldSeeTheUpdatedEducationRecord(string C1, string D1)
        {
            
        }

        [When(@"I Delete Education record on the profile page")]
        public void WhenIDeleteEducationRecordOnTheProfilePage()
        {
            EducationObj.DeleteEducation(driver);
        }

        [Then(@"the Education record should be deleted")]
        public void ThenTheEducationRecordShouldBeDeleted()
        {
            throw new PendingStepException();
        }


        //[When(@"I create the Certificates and Certified '([^']*)','([^']*)' on the profile page")]
        //public void WhenICreateTheCertificatesAndCertifiedOnTheProfilePage(string P0, string F0)
        //{
           
        //}

        //[Then(@"I could see the created record '([^']*)','([^']*)'")]
        //public void ThenICouldSeeTheCreatedRecord(string P0, string F0)
        //{
           
        //}

        
        [When(@"I update the Certificates and Certified '([^']*)','([^']*)' on the profile page")]
        public void WhenIUpdateTheCertificatesAndCertifiedOnTheProfilePage(string P1, string F1)
        {
            
        }

        [Then(@"I could see the updated certificates and certfied record '([^']*)','([^']*)'")]
        public void ThenICouldSeeTheUpdatedCertificatesAndCertfiedRecord(string P1, string F1)
        {
           
        }

        [When(@"I Delete Certifications record on the profile page")]
        public void WhenIDeleteCertificationsRecordOnTheProfilePage()
        {
            
        }
                   

        [Then(@"the Certifications and certified record should be deleted")]
        public void ThenTheCertificationsAndCertifiedRecordShouldBeDeleted()
        {
            throw new PendingStepException();
        }

    }
}
