using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Yusha.Selenium
{
    internal class WishListTest : BaseTest
    {
        [Test]
        public void wishlisttest()
        {
            //First Step : Login

            var signin = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[3]/div/a/p")));
            signin.Click();

            var phonenum = driver.FindElement(By.Id("phone_number"));
            phonenum.SendKeys("01786492383");

            var loginbtn = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div/div/div/section/div/div/div[1]/div[1]/div/div/div[2]/div/div/form/div/div[4]/button"));
            loginbtn.Click();

            System.Threading.Thread.Sleep(3000);

            //Second Step: Add to Wishlist any product

            //var slider = driver.FindElement(By.XPath("//*[@id=\"__layout\"]/main/div/div[1]/div/div/div/div[1]/div/div[1]/div[1]/div[1]/div/a/button"));
            //slider.Click();

            //System.Threading.Thread.Sleep(3000);
            //var wishlistbtn = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__layout\"]/main/div/div/div/div/div[2]/div/div[2]/div/div[2]/div/div/div/div[1]/div/div[1]/div/div[1]/div[1]/button")));
            //wishlistbtn.Click();

            //System.Threading.Thread.Sleep(3000);

            //navigate to wishlist page
            var wishlisticon = driver.FindElement(By.XPath("//*[@id=\"__yusha\"]/header/div[3]/div/div/div[3]/div/ul/li[1]/a"));
            wishlisticon.Click();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
