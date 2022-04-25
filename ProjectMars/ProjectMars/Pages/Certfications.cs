using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMars.Profile
{
    public class Certifications
    {

        public void CreateCertifications(IWebDriver driver, string Certificate, string Certified)
        {
            //check if seller can create certifications

            //search for certifications button 

            IWebElement Certificationsbutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            Certificationsbutton.Click();

            //search for Addnew button

            IWebElement AddnewbuttonCertifications = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            AddnewbuttonCertifications.Click();

            //search for certificate textbox

            IWebElement AddCertificatextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            AddCertificatextbox.Click();
            AddCertificatextbox.SendKeys(Certificate);


            //Search for certified textbox

            IWebElement Certifiedtextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            Certifiedtextbox.SendKeys(Certified);

            // select year from dropbox

            IWebElement Year = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]"));
            Year.Click();

            // search for add

            IWebElement Add = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            Add.Click();

            Thread.Sleep(5000);

            


        }
        public string Getrecord(IWebDriver driver)
        {

            IWebElement actualrecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));

            return actualrecord.Text;


        }





    }
}
