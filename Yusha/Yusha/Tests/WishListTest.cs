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
    internal class WishListTest : BaseTest
    {
        [Test]
        [AllureSeverity]
        [AllureLink("Website", "https://yusha.com.bd/")]
        [AllureSuite("Browser tests")]
        [AllureDescription("As user I want to  WishList product to the wesbsite")]
        public void wishlisttest()
        {
            
        }
    }
}
