﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    internal class LoginPage
    {

        public void Loginsteps(IWebDriver driver)
        {

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




        }



























    }
}
