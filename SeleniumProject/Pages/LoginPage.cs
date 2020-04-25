using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)

        {
            //navigating to demo site
            //enter URL
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

        //maximise window
        driver.Manage().Window.Maximize();

            //enter username
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

        //enter password
        driver.FindElement(By.Id("Password")).SendKeys("123123");

        //click on submit button
        driver.FindElement(By.XPath("/html/body/div[4]/div/div/section/form/div[3]/input[1]")).Click();
    }

}
}
