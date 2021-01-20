using OpenQA.Selenium;

namespace WebTestProject
{
    public class SD_CheckoutPage1
    {
        private IWebDriver _seleniumDriver;
        private string CheckoutPage1URL = AppConfigReader.CheckoutUrl1;

        private IWebElement _firstNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postalCodeField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _btnCancel => _seleniumDriver.FindElement(By.LinkText("CANCEL"));
        private IWebElement _btnContinue => _seleniumDriver.FindElement(By.LinkText("CONTINUE"));
        private IWebElement _alert => _seleniumDriver.FindElement(By.TagName("h3"));

        public SD_CheckoutPage1(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitCheckout1()
        {
            _seleniumDriver.Navigate().GoToUrl(CheckoutPage1URL);
        }

        private void FirstNameInput(string firstName)
        {
            _firstNameField.SendKeys(firstName);
        }

        private void LastNameInput(string lastName)
        {
            _lastNameField.SendKeys(lastName);
        }

        private void PostCodeInput(string postCode)
        {
            _postalCodeField.SendKeys(postCode);
        }

        private void ClickCancel()
        {
            _btnCancel.Click();
        }

        private void ClickContinue()
        {
            _btnContinue.Click();
        }

        private string GetAlert()
        {
            return _alert.Text;
        }
    }
}