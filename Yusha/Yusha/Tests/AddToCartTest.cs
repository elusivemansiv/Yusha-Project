using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Yusha.Selenium
{
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void addtocarttest()
        {
            //First Step : Login

            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[3]/div/a/p")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("01786492383");

            var loginbtn = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/section/div/div/div[1]/div[1]/div/div/div[2]/div/div/form/div/div[4]/button"));
            loginbtn.Click();

            System.Threading.Thread.Sleep(3000);

            //navigate to Add to cart page
            var addtocarticon = driver.FindElement(By.XPath("//*[@id=\"__yusha\"]/header/div[3]/div/div/div[3]/div/ul/li[2]/div/a"));
            addtocarticon.Click();
            System.Threading.Thread.Sleep(3000);



        }
    }
}
