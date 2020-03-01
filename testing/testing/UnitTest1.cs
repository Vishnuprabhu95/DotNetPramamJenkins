using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;



        string EnvBrw = Environment.GetEnvironmentVariable("Browser");





        [SetUp]
        public void startBrowser()
        {

            switch(EnvBrw)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }







            //if (EnvBrw.Equals("Chrome"))
            //{
            //    driver = new ChromeDriver();
            //}
            //else if (EnvBrw.Equals("Firefox"))
            //{
            //    driver = new FirefoxDriver();
            //}
            //else
            //{
            //    driver = new ChromeDriver();
            //}

        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.com/";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
