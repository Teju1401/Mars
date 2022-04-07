using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class HomePage
    {

        public void Gotoprofilehomepage(IWebDriver driver)
        {
            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/a[2]", 60);

            //check if seller can navigated to profile home page
            // search for profile icon

            IWebElement Profileicon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            Profileicon.Click();

            Thread.Sleep(3000);

           
        }
        public string Getactualname(IWebDriver driver)
        {
            IWebElement actualname = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            return actualname.Text;

        }
    }
}
