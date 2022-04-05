using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    internal class Languages
    {
        public void CreateLanguages(IWebDriver driver)
        {
            Thread.Sleep(6000);
            //check if seller can add Languages

            //search for language button to add new languages in profile page

            IWebElement Languagebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languagebutton.Click();

            //search for Addnew button

            IWebElement Addnewbuttonlanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            Addnewbuttonlanguage.Click();

            //search for Languages textbox

            IWebElement AddLanguagetextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            AddLanguagetextbox.Click();
            AddLanguagetextbox.SendKeys("English");

            //Select choose language level dropbox

            IWebElement Languagelevelbuttion = driver.FindElement(By.CssSelector("[class='ui dropdown']"));
            SelectElement LanguageElement = new SelectElement(Languagelevelbuttion);
            LanguageElement.SelectByIndex(2);

            //Search for Add button for languages

            IWebElement LanguageAddbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
            LanguageAddbutton.Click();

            Wait.Waittobeclickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)", 2);


            // check if the record is created

            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

            //assertion

            Assert.That(actualLanguage.Text == "English", "actual Language and expexted Language donot match");

        }

        public string GetactualLanguage(IWebDriver driver)
        {
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualLanguage.Text;
        }

        public void UpdateLanguages(IWebDriver driver)
        {

            //Edit the languages on profie page

            // search for edit languages button

            IWebElement EditLanguagesbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
            EditLanguagesbutton.Click();

            // search for Edit Languages Textbox

            IWebElement EditLanguagestextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
            EditLanguagestextbox.Click();
            EditLanguagestextbox.Clear();
            EditLanguagestextbox.SendKeys("Hindi");

            //Edit Language Level

            IWebElement Editlanguagelevel = driver.FindElement(By.CssSelector("[class='ui dropdown']"));
            SelectElement EditLanguageElement = new SelectElement(Editlanguagelevel);
            EditLanguageElement.SelectByIndex(1);

            //search for update button for languages

            IWebElement Languageupdatebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
            Languageupdatebutton.Click();

            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]", 2);

            // check if the record is updated

            

            //assertion

            Assert.That(actualupdatedLanguage.Text == "Hindi", "actual updated Language and expexted updated Language donot match");
        }

        public string GetactualupdatedLanguage(IWebDriver driver)
        {
            IWebElement actualupdatedLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualupdatedLanguage.Text;
        }
        public void DeleteLanguages(IWebDriver driver)
        { 

            // delete the updated profile Languages

            // search for delete button to delete updated languages on profile page

            IWebElement Languagedeltebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            Languagedeltebutton.Click();







        }

















    }
}
