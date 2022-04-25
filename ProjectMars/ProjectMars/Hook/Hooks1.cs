using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Profile;
using ProjectMars.Utilities;
using TechTalk.SpecFlow;

namespace ProjectMars.Hook
{
    [Binding]
    public sealed class Hooks1 : CommonDriver
    {
        //// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            // Login page object initialization and definition

            LoginPage loginpageObj = new LoginPage();
            loginpageObj.Loginsteps(driver);

            HomePage homepageObj = new HomePage();
            homepageObj.Gotoprofilehomepage(driver);
                      


        }

        
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}