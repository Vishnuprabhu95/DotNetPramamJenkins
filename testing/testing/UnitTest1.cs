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
        string URL = Environment.GetEnvironmentVariable("url");





        [SetUp]
        public void startBrowser()
        {

            switch(EnvBrw)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    Console.WriteLine("Chrome");
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    Console.WriteLine("Firefox");
                    break;
                default:
                    driver = new ChromeDriver();
                    Console.WriteLine("default browser");
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
        [TestCategory("smoke")]
        public void test()
        {
            switch (URL)
            {
                case "google":
                    driver.Url = "http://www.google.com/";
                    Console.WriteLine("google");
                    break;
                case "amazon":
                    driver.Url = "http://www.amazon.in/";
                    Console.WriteLine("amazon");
                    break;
                //default:
                //    driver.Url = "http://www.amazon.in/";
                //    Console.WriteLine("default url");
                //    break;
            }
           
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close(); driver.Dispose();
        }
    }
}
