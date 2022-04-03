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

            //search for language button to add new languages in profile page

            IWebElement Languagesbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)"));
            Languagesbutton.Click();

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

            Thread.Sleep(5000);

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

            Thread.Sleep(4000);

            //check if created value is present in the record

            //IWebElement ActualLanguageName = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

            //assertion

            //Assert.That(ActualLanguageName.Text == "Hindi", "actual name do not match the record");

            // delete the updated profile Languages

            // search for delete button to delete updated languages on profile page

            IWebElement Languagedeltebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            Languagedeltebutton.Click();





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

            Thread.Sleep(5000);

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

            Thread.Sleep(4000);

            // delete the updated profile skills

            // search for deletebutton for updated skills on profile page

            IWebElement skilldeltebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            skilldeltebutton.Click();


            //check if created record is presented in the table

            //IWebElement Actualskillname = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr[last]/td[1]"));

            //Assertion

            //Assert.That(Actualskillname.Text == "Cricket", "actual name do Not match the record");

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

            Thread.Sleep(2000);

            //Edit the Education on profie page

            // search for edit Education button

            IWebElement EditEducationbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
            EditEducationbutton.Click();
            Thread.Sleep(2000);

            // search for Edit Education Textbox

            IWebElement EditEducationtextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            AddCollegetextbox.Click();
            AddCollegetextbox.SendKeys("QWERTY");

            //Edit Country Level

            IWebElement Editcountry = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]"));
            Editcountry.Click();

            // Edit title dropbox

            IWebElement EditTitlebutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[3]"));
            EditTitlebutton.Click();

            //Edit degree textbox

            IWebElement EditDegreetextbox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(2) > input[type=text]"));
            EditDegreetextbox.Click();
            EditDegreetextbox.SendKeys("EFG");

            //Edit graduate dropbox

            IWebElement EditGraduatedropbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[4]"));
            EditGraduatedropbox.Click();

            //search for update button for Education

            IWebElement Educationupdatebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
            Educationupdatebutton.Click();

            //check if created value is present in the record

            //IWebElement ActualEducationrecord = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr[last] > td[1]"));

            //assertion

            //Assert.That(ActualEducationrecord.Text == "Hindi", "actual name do not match the record");

            // delete the updated profile skills

            // search for delete button to delete updated Education on profile page

            //IWebElement Educationdeltebutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(2)"));
            //Educationdeltebutton.Click();




            //check if seller can add Certificates


































































        }
    }
}
