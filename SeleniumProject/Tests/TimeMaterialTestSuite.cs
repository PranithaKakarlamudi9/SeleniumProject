using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumProject.Pages;
using NUnit.Framework;
using SeleniumProject.Helpers;

namespace SeleniumProject.Tests
{
    [TestFixture, Description("creation of tests for Tie and Material")]
    [Parallelizable]
    class TimeMaterialTestSuite : CommonDriver
    {
        
            [Test, Order(1), Description("creating Time and Material")]
            public void CreateTmTest()
            {
                TMPage tmobj = new TMPage();

                tmobj.CreateTM(driver);

            }

            [Test, Order(2),Description("Editing time/material")]
            public void EditTmTest()
            {
                TMPage tmobj = new TMPage();
                tmobj.EditTM(driver);
            }

            [Test,Order(3) ,Description("Delete time/material")]
            public void DeleteTmTest()
            {
                TMPage tmobj = new TMPage();
                tmobj.DeleteTM(driver);
            }
        }
}
