using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace SeleniumProject.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //create new time/material.

            // click on create new
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Create new record
            Thread.Sleep(2000);
            //click on dropdown
            driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000);

            //selecting time in dropdown
            driver.FindElement(By.XPath("/html/body/div[5]/div/ul/li[2]")).Click();

            //enter  code in code txtbox
            driver.FindElement(By.Id("Code")).SendKeys("newrec1");

            //enter description in description box
            driver.FindElement(By.Id("Description")).SendKeys(" description for newrec1");

            //enter price in price textbox
            driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]")).SendKeys("898976");

            //click on save button to save the record
            driver.FindElement(By.Id("SaveButton")).Click();


            // click on back link list if user does not want ot save record
            //driver.FindElement(By.LinkText("Back to List")).Click();

            //validating if record created
            //validating record creation in list by traversing to last page

            //navigating to last page pagenavigation
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(2000);

            //checking for record created above
            if (driver.FindElement(By.XPath("//div[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "newrec1")//selecting last row based on record

            {
                Console.WriteLine("record created");
                Assert.Pass();
            }
            Assert.That(driver.FindElement(By.XPath("//div[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text, Is.EqualTo("newrec1"));

        }
        public void EditTM(IWebDriver driver)
        {
            // wait
            Thread.Sleep(2000);

            //click on edit button
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

            //click on dropdown
            driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000);

            //choose time in dropdown
            driver.FindElement(By.XPath("/html/body/div[5]/div/ul/li[2]")).Click();

            //entering code in code textbox
            driver.FindElement(By.Id("Code")).SendKeys("newrec2");

            //entering discription in description textbox
            driver.FindElement(By.Id("Description")).SendKeys(" description for newrec2");

            //entering price in price textbox
            driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]")).SendKeys("500000");

            //click on save button to save record
            driver.FindElement(By.Id("SaveButton")).Click();//getting stuck at save and throwing error

            //driver.FindElement(By.LinkText("Back to List")).Click();
            Thread.Sleep(5000);
            //validating edit
            driver.FindElement(By.XPath("//div[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(1000);
            if (driver.FindElement(By.XPath("//div[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "newrec2")
            {
                
                Assert.Pass();
            }
            else
            {
                
                Assert.Fail();
            }


        }
        public void DeleteTM(IWebDriver driver)
        {
            //Delte button in List page

            //click on delete button
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[1]/td[5]/a[2]")).Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            //alert.Dismiss();

            //driver.SwitchTo().Alert().Accept();
            //  driver.SwitchTo().Alert().Dismiss();

            //validating delete
            if (driver.FindElement(By.XPath("//div[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text.Contains("newrec"))
            {
                
                Assert.Pass();
            }
            else
            {
               
                Assert.Fail();
            }


        }
    }
}
