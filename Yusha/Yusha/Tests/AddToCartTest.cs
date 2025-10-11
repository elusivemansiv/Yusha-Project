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
    internal class AddToCartTest : BaseTest
    {
        [Test]
        public void addtocarttest()
        {
            var CategorySection = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[text()='Product Categories']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", CategorySection);
            
            var clickCategory = driver.FindElement(By.XPath("//div[@class='col-lg-2']//a[@href='/clothes']//h3[text()='Clothes']"));
            clickCategory.Click();
            Thread.Sleep(1000);

            var clickItem = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='col-lg-3']//div[@title='New Polka Small Dots Cat Kitty Lace Collar Two-Piece Set - Long Sleeve Vest Dress']")));
            clickItem.Click();
            Thread.Sleep(1000);

            var AddCartSection = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@class='add-to-cart-btn']//span[text()='Add to cart']")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", AddCartSection);
            AddCartSection.Click();

            Thread.Sleep(1000);
            var requiredSignIn = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='modal-content']//input[@id='phone_number']")));
            requiredSignIn.SendKeys("01786492383");
            var loginBtn = driver.FindElement(By.XPath("//div[@class='form-group']//span[text()='Login']"));
            loginBtn.Click();
            Thread.Sleep(1000);

            AddCartSection.Click();

            Thread.Sleep(3000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0);");
            Thread.Sleep(1000);

            // Click Cart icon
            var cartIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='cart-dropdodon-area']//a[contains(@class,'cart-dropdodon-btn')]")));
            cartIcon.Click();

            wait.Until(ExpectedConditions.UrlContains("/checkout"));
            Assert.That(driver.Url.Contains("/checkout"), "Failed to navigate to checkout page after clicking cart icon.");

            Thread.Sleep(2000);

        }
    }
}
