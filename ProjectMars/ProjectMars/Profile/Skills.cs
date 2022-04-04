﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Profile
{
    internal class Skills
    {
        public void AddSkills(IWebDriver driver)
        {
            //search for Skills button and add new skills on profile page

            IWebElement Skillsbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
            Skillsbutton.Click();

            //search for Addnew button

            IWebElement Addnewbuttonskills = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            Addnewbuttonskills.Click();

            //Search for Add Skill textbox

            IWebElement Addskillstextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            Addskillstextbox.Click();
            Addskillstextbox.SendKeys("Listening");

            // select choose Skill level dropbox

            IWebElement Skilllevelbutton = driver.FindElement(By.CssSelector("[class='ui fluid dropdown']"));
            SelectElement SkillsElement = new SelectElement(Skilllevelbutton);

            SkillsElement.SelectByIndex(1);



            // search for add button for skills

            IWebElement AddSkillbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            AddSkillbutton.Click();

            Wait.WaittobeVisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)", 2);
        }
        public void Editskills(IWebDriver driver)
        {

            //search for Edit Skills button

            IWebElement Editskillsbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
            Editskillsbutton.Click();

            // search for Edit Skill level textbox

            IWebElement Editskilllevetextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
            Editskilllevetextbox.Click();
            Editskilllevetextbox.Clear();
            Editskilllevetextbox.SendKeys("Cricket");


            // search for update button

            IWebElement Updatebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
            Updatebutton.Click();

            Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]", 2);
        }
        public void Deleteskills(IWebDriver driver)
        { 

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
