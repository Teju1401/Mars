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
    public class Skills
    {
        public void CreateSkills(IWebDriver driver, string painting)
        {
            Wait.Waittobeclickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 100);
                        
            //search for Skills button and add new skills on profile page

            IWebElement Skillsbutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skillsbutton.Click();

            //search for Addnew button

            IWebElement Addnewbuttonskills = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            Addnewbuttonskills.Click();

            //Search for Add Skill textbox

            IWebElement Addskillstextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            Addskillstextbox.Click();
            Addskillstextbox.SendKeys(painting);

            // select choose Skill level dropbox

            IWebElement Skilllevelbutton = driver.FindElement(By.CssSelector("[class='ui fluid dropdown']"));
            SelectElement SkillsElement = new SelectElement(Skilllevelbutton);

            SkillsElement.SelectByIndex(1);



            // search for add button for skills

            IWebElement AddSkillbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            AddSkillbutton.Click();

            Wait.WaittobeVisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)", 30);

            // check if the record is created

           

            //assertion

           // Assert.That(actualskill.Text == "Listening", "actualskill and expexted skill donot match");



        }
        public string Getactualskill(IWebDriver driver)
        {
            IWebElement actualskill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualskill.Text;
        }
        public void Updateskills(IWebDriver driver, string dancing)
        {
            Thread.Sleep(6000);

            //search for Edit Skills button

            IWebElement Editskillsbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
            Editskillsbutton.Click();

            // search for Edit Skill level textbox

            IWebElement Editskilllevetextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
            Editskilllevetextbox.Click();
            Editskilllevetextbox.Clear();
            Editskilllevetextbox.SendKeys(dancing);

            // select choose Skill level dropbox

            IWebElement Skilllevelbutton = driver.FindElement(By.CssSelector("[class='ui fluid dropdown']"));
            SelectElement SkillsElement = new SelectElement(Skilllevelbutton);

            SkillsElement.SelectByIndex(2);


            // search for update button

            IWebElement Updatebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
            Updatebutton.Click();

            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]", 30);

            // check if the record is created

            

            //assertion

            //Assert.That(actualupdatedskill.Text == "Cricket", "actualskill and expexted skill donot match");



        }
        public string Getactualupdatedskill(IWebDriver driver)
        {
            IWebElement actualupdatedskill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualupdatedskill.Text;

        }

        public void Deleteskills(IWebDriver driver)
        {
            Thread.Sleep(6000);

            // delete the updated profile skills

            // search for deletebutton for updated skills on profile page

            IWebElement skilldeltebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            skilldeltebutton.Click();


            //check if created record is presented in the table

            //IWebElement Actualskillname = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr[last]/td[1]"));

            //Assertion

            //Assert.That(Actualskillname.Text == "Cricket", "actual name do Not match the record");




        }









    }





















   
}
