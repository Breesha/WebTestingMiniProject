using OpenQA.Selenium;

namespace WebTestProject
{
    public class SD_LoginPage
    {
        private IWebDriver _seleniumDriver;
        private string LoginPageURL = AppConfigReader.BaseUrl;

        //IWebElements
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector("*[data-test=\"error\"]"));

        public SD_LoginPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitLoginPage()
        {
            _seleniumDriver.Navigate().GoToUrl(LoginPageURL);
        }

        public void EnterUsername(string username)
        {
            _usernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _loginButton.Click();
        }

        public string ErrorMessage()
        {
            return _errorMessage.Text;
        }
      
        public string GetPageURL()
        {
            return _seleniumDriver.Url;
        }
    }
}
