using OpenQA.Selenium;

namespace WebTestProject
{
    public class SD_Cart
    {
        private IWebDriver _seleniumDriver;
        private string CartPageURL = AppConfigReader.CartUrl;

        private IWebElement _btnContinueShopping => _seleniumDriver.FindElement(By.LinkText("CONTINUE SHOPPING"));
        private IWebElement _btnCheckout => _seleniumDriver.FindElement(By.LinkText("CHECKOUT"));
        private IWebElement _cartItem => _seleniumDriver.FindElement(By.ClassName("cart_item"));

        public SD_Cart(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitCart()
        {
            _seleniumDriver.Navigate().GoToUrl(CartPageURL);
        }

        public void ClickContinueShoppingButton()
        {
            _btnContinueShopping.Click();
        }

        public void ClickCheckoutButton()
        {
            _btnCheckout.Click();
        }

        public IWebElement CheckThereIsAnItemInTheCart()
        {
            try
            {
                return _cartItem;
            }

            catch(NoSuchElementException)
            {
                return null;
            }
        }
    }

}
