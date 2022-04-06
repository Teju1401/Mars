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
        }

        [Given(@"I Loggin to the Mars web portal succesfully")]
        public void GivenILogginToTheMarsWebPortalSuccesfully()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [When(@"I create languages '([^']*)' on the profile page")]
        public void WhenICreateLanguagesOnTheProfilePage(string english)
        {
            
            LanguageObj.CreateLanguages(driver, english);
        }

        [Then(@"the record should be created '([^']*)'")]
        public void ThenTheRecordShouldBeCreated(string english)
        {
            string newactualLanguage = LanguageObj.GetactualLanguage(driver);

        }

        [Given(@"I Loggin to the Mars web portal succesfully to update Languages")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToUpdateLanguages()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }

        [When(@"I update languages '([^']*)' on the profile page")]
        public void WhenIUpdateLanguagesOnTheProfilePage(string hindi)
        {
            
            LanguageObj.UpdateLanguages(driver, hindi);
        }

        [Then(@"I could see the updated language record '([^']*)'")]
        public void ThenICouldSeeTheUpdatedLanguageRecord(string hindi)
        {
            string newactualupdatedLanguage = LanguageObj.GetactualupdatedLanguage(driver);

        }
        [Given(@"I Loggin to the Mars web portal succesfully to delete languages")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToDeleteLanguages()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);
        }


        [When(@"I Delete languages on the profile page")]
        public void WhenIDeleteLanguagesOnTheProfilePage()
        {

            LanguageObj.DeleteLanguages(driver);
        }

        [Then(@"the record should be deleted")]
        public void ThenTheRecordShouldBeDeleted()
        {
            throw new PendingStepException();
        }

        
        [Given(@"I Loggin to the Mars web portal succesfully to create skills")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToCreateSkills()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);

        }
        [Given(@"I navigate to the profile home page to create skills")]
        public void GivenINavigateToTheProfileHomePageToCreateSkills()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }

      
        [When(@"I create Skills '([^']*)' on the profile page")]
        public void WhenICreateSkillsOnTheProfilePage(string painting)
        {

            SkillsObj.CreateSkills(driver, painting);
        }

        

        [Then(@"I could see the created '([^']*)'")]
        public void ThenICouldSeeTheCreated(string painting)
        {
            string newactualskill = SkillsObj.Getactualskill(driver);

        }
        [Given(@"I Loggin to the Mars web portal succesfully to update skills")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToUpdateSkills()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);

        }
        [Given(@"I navigated to profile home page to update skills")]
        public void GivenINavigatedToProfileHomePageToUpdateSkills()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }


        [When(@"I update the Skills '([^']*)' on the profile page")]
        public void WhenIUpdateTheSkillsOnTheProfilePage(string dancing)
        {

            SkillsObj.Updateskills(driver, dancing);
        }

        [Then(@"I could see the updated skills record '([^']*)'")]
        public void ThenICouldSeeTheUpdatedSkillsRecord(string dancing)
        {
            string newactualupdatedskill = SkillsObj.Getactualupdatedskill(driver);

        }

        [Given(@"I Loggin to the Mars web portal succesfully to delete skills")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToDeleteSkills()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);

        }

        [Given(@"I navigated to the profile home page to delete skills")]
        public void GivenINavigatedToTheProfileHomePageToDeleteSkills()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I Delete Skills on the profile page")]
        public void WhenIDeleteSkillsOnTheProfilePage()
        {

            SkillsObj.Deleteskills(driver);
        }

        [Then(@"the Skills record should be deleted")]
        public void ThenTheSkillsRecordShouldBeDeleted()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }

        [Given(@"I Loggin to the Mars web portal succesfully to create education")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToCreateEducation()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);

        }
        [Given(@"I navigated to profile home page to create education")]
        public void GivenINavigatedToProfileHomePageToCreateEducation()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }


        [When(@"I create the College and Degree '([^']*)','([^']*)' on the profile page")]
        public void WhenICreateTheCollegeAndDegreeOnTheProfilePage(string aBC, string p1)
        {

            EducationObj.CreateEducation(driver, aBC, p1);
        }

        [Then(@"I could see the created'([^']*)','([^']*)'")]
        public void ThenICouldSeeTheCreated(string aBC, string p1)
        {
            string newuniversity = EducationObj.Getuniversity(driver);

        }
        [Given(@"I Loggin to the Mars web portal succesfully to update education")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToUpdateEducation()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);

        }
        [Given(@"I navigated to profile home page to update education")]
        public void GivenINavigatedToProfileHomePageToUpdateEducation()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }

        [When(@"I update the College and Degree '([^']*)','([^']*)' on the profile page")]
        public void WhenIUpdateTheCollegeAndDegreeOnTheProfilePage(string qWERTY, string begginer)
        {

            EducationObj.UpdateEducation(driver, qWERTY, begginer);
        }

        [Then(@"I could see the updated education record '([^']*)','([^']*)'")]
        public void ThenICouldSeeTheUpdatedEducationRecord(string qWERTY, string begginer)
        {
            string newUpdateuniversity = EducationObj.GetUpdateuniversity(driver);
        }

        [Given(@"I Loggin to the Mars web portal succesfully to delete education")]
        public void GivenILogginToTheMarsWebPortalSuccesfullyToDeleteEducation()
        {
            driver = new ChromeDriver();

            loginpageObj.Loginsteps(driver);

        }
        [Given(@"I navigated to the profile home page to delete education")]
        public void GivenINavigatedToTheProfileHomePageToDeleteEducation()
        {
           HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
        }


        [When(@"I Delete Education record on the profile page")]
        public void WhenIDeleteEducationRecordOnTheProfilePage()
        {

            EducationObj.DeleteEducation(driver);
        }

        [Then(@"the Education record should be deleted")]
        public void ThenTheEducationRecordShouldBeDeleted()
        {

        }
        

        
    }
}
