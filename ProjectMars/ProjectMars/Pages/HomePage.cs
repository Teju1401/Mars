using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    internal class HomePage
    {

        public void Gotoprofilehomepage(IWebDriver driver)
        {

            IWebElement Profileicon = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[1]/div/a[2]"));
            Profileicon.Click();



            //check if seller can edit First and Last Name on profile page

            //search for name button

            IWebElement Namebutton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            Namebutton.Click();

            //search for First Name textbox

            IWebElement Firstnametextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            Firstnametextbox.Click();
            Firstnametextbox.Clear();
            Firstnametextbox.SendKeys("Teja");

            // search for the Last Name textbox

            IWebElement Lastnametextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            Lastnametextbox.Click();
            Lastnametextbox.Clear();
            Lastnametextbox.SendKeys("M");


            //check if seller can click on save button

            // search for save button

            IWebElement Searchbuttion = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            Searchbuttion.Click();





        }
    }
}
