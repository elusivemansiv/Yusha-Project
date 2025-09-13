using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Yusha.Selenium
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void Logintest()
        {
            
            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[3]/div/a/p")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("01786492383");

            var loginbtn = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/section/div/div/div[1]/div[1]/div/div/div[2]/div/div/form/div/div[4]/button"));
            loginbtn.Click();
        }
    }
}
