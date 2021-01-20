using OpenQA.Selenium;

namespace WebTestProject
{
    public class SD_CheckoutPage2
    {
        private IWebDriver _seleniumDriver;
        private string CheckoutPage2URL = AppConfigReader.CheckoutUrl2;

        private IWebElement _btnCancel => _seleniumDriver.FindElement(By.LinkText("CANCEL"));
        private IWebElement _btnFinish => _seleniumDriver.FindElement(By.LinkText("FINISH"));
        private IWebElement _cartItem => _seleniumDriver.FindElement(By.ClassName("inventory_item_name"));

        public SD_CheckoutPage2(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitCheckout2()
        {
            _seleniumDriver.Navigate().GoToUrl(CheckoutPage2URL);
        }

        public void CancelClick()
        {
            _btnCancel.Click();
        }

        public void FinishClick()
        {
            _btnFinish.Click();
        }

        public void ClickCartItemLink()
        {
            _cartItem.Click();
        }
    }
}
