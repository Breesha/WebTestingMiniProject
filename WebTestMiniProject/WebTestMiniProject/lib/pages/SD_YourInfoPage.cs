using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebTestProject
{
    class SD_YourInfoPage
    {
        private IWebDriver _seleniumDriver;
        private string YourInfoURL = AppConfigReader.YourInfoUrl;

        private IWebElement _fNameField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lNameField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postcodeField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.CssSelector("#checkout_info_container > div > form > div.checkout_buttons > a"));
        private IWebElement _continueButton => _seleniumDriver.FindElement(By.CssSelector("#checkout_info_container > div > form > div.checkout_buttons > input"));

        public SD_YourInfoPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitYourInfoPage()
        {
            _seleniumDriver.Navigate().GoToUrl(YourInfoURL);
        }

        public void InputFirstName(string firstName)
        {
            _fNameField.SendKeys(firstName);
        }

        public void InputLastName(string lastName)
        {
            _lNameField.SendKeys(lastName);
        }

        public void InputPostalCode(string postalCode)
        {
            _postcodeField.SendKeys(postalCode);
        }

        public void ClickCancel()
        {
            _cancelButton.Click();
        }

        public void ClickCcontinue()
        {
            _continueButton.Click();
        }
    }
}
