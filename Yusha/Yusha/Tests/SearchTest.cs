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
    internal class SearchTest : BaseTest
    {

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to Search shoe product to the wesbsite with valid Data")]
        public void SearchShoeTest()
        {
            
            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-search-area']//input[@placeholder='What you are looking for?']")));
            searchbar.SendKeys("anti");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("anti") || d.Url.Contains("yp"));
            Thread.Sleep(3000);

            
        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to Search Toy product to the wesbsite with valid Data")]
        public void SearchToyTest()
        {

            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-search-area']//input[@placeholder='What you are looking for?']")));
            searchbar.SendKeys("Wrist");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("Wrist") || d.Url.Contains("yp"));
            Thread.Sleep(3000);


        }


        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to Search Bag product to the wesbsite with valid Data")]
        public void SearchBagTest()
        {

            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-search-area']//input[@placeholder='What you are looking for?']")));
            searchbar.SendKeys("Bag");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("Bag") || d.Url.Contains("yp"));
            Thread.Sleep(3000);


        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to Search Wrong product to the wesbsite with Invalid Data")]
        public void SearchProductWrongDataTest()
        {

            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-search-area']//input[@placeholder='What you are looking for?']")));
            searchbar.SendKeys("Game");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("Game") || d.Url.Contains("yp"));

        }

        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to Search product to the wesbsite with No Data")]
        public void SearchProductNoDataTest()
        {

            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-bottom-search-area']//input[@placeholder='What you are looking for?']")));
            searchbar.SendKeys("");

            System.Threading.Thread.Sleep(2000);

            var searchitem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'header-area__search-suggestion-area')]//ul[@class='suggestions']/li[1]/a")));
            searchitem.Click();

            wait.Until(d => d.Url.Contains("") || d.Url.Contains("yp"));

        }

    }
}
