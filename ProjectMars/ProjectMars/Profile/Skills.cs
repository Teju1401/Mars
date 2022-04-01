using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Profile
{
    internal class Skills
    {
        public void EditSkills(IWebDriver driver)
        {

            //check if seller can add Skills

            //search for Skills button on profile page

            IWebElement Skillsbutton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skillsbutton.Click();

            //search for Addnew button

            IWebElement Addnewbutton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Addnewbutton.Click();

            //Search for Add Skill textbox

            IWebElement Addskillstextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Addskillstextbox.Click();
            Addskillstextbox.SendKeys()




        }





















    }
}
