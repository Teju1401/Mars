using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ProjectMars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // launch chrome driver

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();


            // launch web portal

            driver.Navigate().GoToUrl("http://localhost:5000");

            //check if seller can login to the web portal with valid credentials

            //search for signin button

            IWebElement Signinbutton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            Signinbutton.Click();

            // search for emailid textbox
            IWebElement Emailidtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            Emailidtextbox.Click();
            Emailidtextbox.SendKeys("tejakumari.teju@gmail.com");

            // search for password textbox

            IWebElement Passwordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            Passwordtextbox.Click();
            Passwordtextbox.SendKeys("Teju@1401");

            // search for Login button

            IWebElement Loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")); 
            Loginbutton.Click();

            Thread.Sleep(5000);

            //check if seller can navigated to profile home page
            // search for profile icon

            IWebElement Profileicon = driver.FindElement(By.CssSelector("#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)"));
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

            //check if seller can add Languages



            //check if seller can add Skills

            //check if seller can add Skills

            //search for Skills button and add new skills on profile page

            IWebElement Skillsbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
            Skillsbutton.Click();

            //search for Addnew button

            IWebElement Addnewbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            Addnewbutton.Click();

            //Search for Add Skill textbox

            IWebElement Addskillstextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            Addskillstextbox.Click();
            Addskillstextbox.SendKeys("Listening");

            // choose Skill level

            IWebElement Skilllevelbutton = driver.FindElement(By.CssSelector("[class='ui fluid dropdown']"));
            SelectElement element = new SelectElement(Skilllevelbutton);

            element.SelectByIndex(1);

            

            // search for add button

            IWebElement Addbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            Addbutton.Click();
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

            //check if created record is presented in the table

            IWebElement Actualskillname = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr[1]"));

            //Assertion

            Assert.That(Actualskillname.Text == "Cricket", "actual name do Not match the record");

            //check if seller can add Education

            //check if seller can add Certificates


































































        }
    }
}
