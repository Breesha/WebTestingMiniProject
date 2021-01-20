using OpenQA.Selenium;

namespace WebTestProject
{
    public class SD_HomePage
    {
        private IWebDriver _seleniumDriver;
        private string HomePageURL = AppConfigReader.BaseUrl;

        //IWebElements

        public SD_HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(HomePageURL);
        }
    }
}
