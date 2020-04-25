using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject.Pages;

namespace SeleniumProject.Helpers
{
    class CommonDriver
    {
        // we intialise our diver as global variable.
        public IWebDriver driver { set; get; }

        [OneTimeSetUp]
        public void TestSetUp()
        {
            //defining driver
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            //loginpg obj
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);

            //homepage object
            HomePage homeobj = new HomePage();
            homeobj.NavigaeToTMPage(driver);

            //Tmpage obj
            TMPage tmobj = new TMPage();
            tmobj.CreateTM(driver);


            //customer page obj
            //CustomerPage customerobj = new CustomerPage();
            //customerobj.CreateCustomer(driver);
        }
        [TearDown]
        //test closure activities 
        public void TestTD()
        {
            driver.Quit();
        }

    }
}
