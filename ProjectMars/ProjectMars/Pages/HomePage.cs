using OpenQA.Selenium;
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

            //check if seller can navigated to profile home page
            // search for profile icon

            IWebElement Profileicon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            Profileicon.Click();



            //check if seller can edit First and Last Name on profile page

            //search for name button

            IWebElement Namebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i"));
            Namebutton.Click();


            //search for First Name textbox

            IWebElement Firstnametextbox = driver.FindElement(By.Name("firstName"));
            Firstnametextbox.Click();
            Firstnametextbox.Clear();
            Firstnametextbox.SendKeys("Teja");

            // search for the Last Name textbox

            IWebElement Lastnametextbox = driver.FindElement(By.Name("lastName"));
            Lastnametextbox.Click();
            Lastnametextbox.Clear();
            Lastnametextbox.SendKeys("M");


            //check if seller can click on save button

            // search for save button

            IWebElement Savebuttion = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button"));
            Savebuttion.Click();
            Thread.Sleep(3000);





        }
    }
}
