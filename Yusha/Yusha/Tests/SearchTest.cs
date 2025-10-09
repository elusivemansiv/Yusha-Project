using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Yusha.Selenium
{
    internal class SearchTest : BaseTest
    {
        [Test]
        public void SearchShoe()
        {
            
            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[2]/div/div/div[1]/input")));
            searchbar.SendKeys("anti");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("anti") || d.Url.Contains("yp"));
            Thread.Sleep(3000);

            
        }

        [Test]
        public void SearchToy()
        {

            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[2]/div/div/div[1]/input")));
            searchbar.SendKeys("Wrist");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("Wrist") || d.Url.Contains("yp"));
            Thread.Sleep(3000);


        }


        [Test]
        public void SearchBag()
        {

            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[2]/div/div/div[1]/input")));
            searchbar.SendKeys("Bag");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("Bag") || d.Url.Contains("yp"));
            Thread.Sleep(3000);


        }

    }
}
