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
        public void ValidPhoneNumber()
        {
            
            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[3]/div/a/p")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("01786492383");

            var loginbtn = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/section/div/div/div[1]/div[1]/div/div/div[2]/div/div/form/div/div[4]/button"));
            loginbtn.Click();

            wait.Until(ExpectedConditions.UrlMatches("https://yusha.com.bd/"));
            Assert.That(driver.Url.Contains("yusha.com.bd"), "Login failed — user not redirected to home page.");
            Thread.Sleep(1000);
        }

        [Test]
        public void InValidPhoneNumber()
        {

            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[3]/div/a/p")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("0000000000");

            var loginbtn = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/section/div/div/div[1]/div[1]/div/div/div[2]/div/div/form/div/div[4]/button"));
            loginbtn.Click();
            var errorMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span.error-message")));

            string expectedMessage = "Phone number must start with 01 and be 11 digits";
            Assert.AreEqual(expectedMessage, errorMessage.Text, "Error message text mismatch or not displayed.");
        }
    }
}
