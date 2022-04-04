using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Profile
{
    internal class Education
    {
        public void AddEducation(IWebDriver driver)
        {
            //check if seller can add Education

            //search for Education button to add Education in profile page

            IWebElement Educationbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)"));
            Educationbutton.Click();

            //search for Addnew button

            IWebElement AddnewbuttonEducation = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddnewbuttonEducation.Click();

            //search for College textbox

            IWebElement AddCollegetextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.ten.wide.field > input[type=text]"));
            AddCollegetextbox.Click();
            AddCollegetextbox.SendKeys("ABC");


            //Select Country of college dropbox

            IWebElement countrybuttion = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            countrybuttion.Click();
            // select title dropbox

            IWebElement Titlebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[9]"));
            Titlebutton.Click();

            //search for degree textbox

            IWebElement Degreetextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(2) > input[type=text]"));
            Degreetextbox.Click();
            Degreetextbox.SendKeys("XYZ");

            //search for year of graduate dropbox

            IWebElement Graduatedropbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[10]"));
            Graduatedropbox.Click();

            //Search for Add button for Education

            IWebElement EducationAddbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(3) > div > input.ui.teal.button"));
            EducationAddbutton.Click();

            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]", 2);
        }
        public void EditEducation(IWebDriver driver)
        {

            //Edit the Education on profie page

            // search for edit Education button

            IWebElement EditEducationbutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]"));
            EditEducationbutton.Click();
            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input", 2);

            // search for Edit Education Textbox

            IWebElement EditEducationtextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            EditEducationtextbox.Click();
            EditEducationtextbox.Clear();
            EditEducationtextbox.SendKeys("QWERTY");

            //Edit Country Level

            IWebElement Editcountry = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select/option[11]"));
            Editcountry.Click();

            // Edit title dropbox

            IWebElement EditTitlebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[3]"));
            EditTitlebutton.Click();

            //Edit degree textbox

            IWebElement EditDegreetextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            EditDegreetextbox.Click();
            EditDegreetextbox.Clear();
            EditDegreetextbox.SendKeys("EFG");

            //Edit graduate dropbox

            IWebElement EditGraduateyeardropbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[4]"));
            EditGraduateyeardropbox.Click();

            //search for update button for Education

            IWebElement Educationupdatebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            Educationupdatebutton.Click();

            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]", 2);

            //check if created value is present in the record

            //IWebElement ActualEducationrecord = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr[last] > td[1]"));

            //assertion

            //Assert.That(ActualEducationrecord.Text == "Hindi", "actual name do not match the record");
        }
        public void DeleteEducation(IWebDriver driver)
        { 

            // delete the updated profile skills

            // search for delete button to delete updated Education on profile page

            IWebElement Educationdeltebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]"));
            Educationdeltebutton.Click();





        }



























    }
}
