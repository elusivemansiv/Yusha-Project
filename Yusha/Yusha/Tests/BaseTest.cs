using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Yusha
{
    internal class BaseTest
    {
        protected IWebDriver driver;          
        protected WebDriverWait wait;
        private static readonly string url = "https://yusha.com.bd/";

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            driver = new ChromeDriver(chromeOptions);  
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
