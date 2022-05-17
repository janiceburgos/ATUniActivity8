using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATUniActivity8
{
    [TestClass]
    public class UnitTest1
    {
        WebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            
            driver.Navigate().GoToUrl("https://www.google.com");
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
        }
        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void Close()
        {
            driver.Quit();
        }
        }
    }

