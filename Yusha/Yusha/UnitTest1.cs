using System;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yusha
{
    public class Tests
    {
        private WebDriver driver;
        private WebDriverWait wait;
        private string filepath = @"";

        private static readonly string url = "https://yusha.com.bd/";


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Test1()
        {
            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[3]/div/a/p")));
            signin.Click();
            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("01786492383");

            var loginbtn = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/section/div/div/div[1]/div[1]/div/div/div[2]/div/div/form/div/div[4]/button"));
            loginbtn.Click();

            System.Threading.Thread.Sleep(3000);
        }


        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}






       