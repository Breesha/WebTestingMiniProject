using OpenQA.Selenium;
using System;

namespace WebTestProject
{
    public class SD_HomePage
    {
        private IWebDriver _seleniumDriver;
        private string HomePageURL = AppConfigReader.BaseUrl;

        //IWebElements
        private IWebElement _cartLink => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement _btnAddToCart => _seleniumDriver.FindElement(By.XPath("//*[@id=\"inventory_container\"]/div/div[1]/div[3]/button"));

        public SD_HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void ClickCart()
        {
            _cartLink.Click();
        }

        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(HomePageURL);
        }

        public void AddItemToCart()
        {
            _btnAddToCart.Click();
        }
    }
}
