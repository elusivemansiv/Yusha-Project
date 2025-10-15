using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Yusha.Selenium
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    internal class LoginTest : BaseTest
    {
        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with valid phonenumber")]
        public void ValidPhoneNumberTest()
        {
            
            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-user-area']//a[@href='/login']")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("01786492383");

            var loginbtn = driver.FindElement(By.XPath("//div[@class='form-group']//span[text()='Login']"));
            loginbtn.Click();

            wait.Until(ExpectedConditions.UrlMatches("https://yusha.com.bd/"));
            Assert.That(driver.Url.Contains("yusha.com.bd"), "Login failed — user not redirected to home page.");
            Thread.Sleep(1000);
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with invalid phone number")]
        public void InValidPhoneNumberTest()
        {

            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-user-area']//a[@href='/login']")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("0000000000");

            var loginbtn = driver.FindElement(By.XPath("//div[@class='form-group']//span[text()='Login']"));
            loginbtn.Click();
            var errorMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.error-message")));

            string expectedMessage = "Phone number must start with 01 and be 11 digits";
            Assert.AreEqual(expectedMessage, errorMessage.Text, "Error message text mismatch or not displayed.");
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to login to the wesbsite with no phone number")]
        public void NoPhoneNumberTest()
        {

            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-user-area']//a[@href='/login']")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("");

            var loginbtn = driver.FindElement(By.XPath("//div[@class='form-group']//span[text()='Login']"));
            loginbtn.Click();
            var errorMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.error-message")));

            string expectedMessage = "Phone number must start with 01 and be 11 digits";
            Assert.AreEqual(expectedMessage, errorMessage.Text, "Error message text mismatch or not displayed.");
        }
    }
}
