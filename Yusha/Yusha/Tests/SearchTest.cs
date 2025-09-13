using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Yusha.Selenium
{
    internal class SearchTest : BaseTest
    {
        [Test]
        public void Searchtest()
        {
            
            var searchbar = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"__yusha\"]/header/div[2]/div/div/div[2]/div/div/div[1]/input")));
            searchbar.SendKeys("Wrist");

            System.Threading.Thread.Sleep(2000);

            //var searchitem = driver.FindElement(By.XPath("span[text()='Wrist Pendant Plush Toys']"));
            //searchitem.Click();


        }
    }
}
