using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    class HomePage
    {
        public void ValidateLogin(IWebDriver driver)
        {

            Assert.That(driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text, Is.EqualTo("Hello hari!"));
        }
        public void NavigaeToTMPage(IWebDriver driver)

        {

            //click time and materials in homepage
            //click on admin dropdown
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //navigate to time and mat list page
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(2000);

        }
    }
}
