using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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

            driver.Navigate().GoToUrl("http://localhost:5000/");

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


            //check if seller can navigated to profile home page
            // search for profile icon

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

           
            //check if seller can add Languages

            //check if seller can add Skills

            //check if seller can add Education

            //check if seller can add Certificates


































































        }
    }
}
