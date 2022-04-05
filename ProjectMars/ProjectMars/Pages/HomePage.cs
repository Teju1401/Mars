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
    internal class HomePage
    {

        public void Gotoprofilehomepage(IWebDriver driver)
        {
            Thread.Sleep(4000);

            //check if seller can navigated to profile home page
            // search for profile icon

            IWebElement Profileicon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            Profileicon.Click();

            // check if profile name is present on the profile home page

            

            // assertion

            //Assert.That(actualname.Text == "Teja Kumari Mangam", "actual name and expected name donot match");



            //search for name button

            //IWebElement Namebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i"));
            //Namebutton.Click();


            //search for First Name textbox

            //IWebElement Firstnametextbox = driver.FindElement(By.Name("firstName"));
            //Firstnametextbox.Click();
            //Firstnametextbox.Clear();
            //Firstnametextbox.SendKeys("Teja");

            //// search for the Last Name textbox

            //IWebElement Lastnametextbox = driver.FindElement(By.Name("lastName"));
            //Lastnametextbox.Click();
            //Lastnametextbox.Clear();
            //Lastnametextbox.SendKeys("M");


            ////check if seller can click on save button

            //// search for save button

            //IWebElement Savebuttion = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button"));
            //Savebuttion.Click();
            ////Thread.Sleep(6000);





        }
        public string Getactualname(IWebDriver driver)
        {
            IWebElement actualname = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div"));
            return actualname.Text;
        }
    }
}
