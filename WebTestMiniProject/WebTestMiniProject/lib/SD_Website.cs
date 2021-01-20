using OpenQA.Selenium;

namespace WebTestProject
{
    public class SD_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public SD_HomePage SD_HomePage { get; internal set; }
        public SD_Cart SD_Cart { get; internal set; }
        public SD_CheckoutPage1 SD_CheckoutPage1 { get; internal set; }
        public SD_CheckoutPage2 SD_CheckoutPage2 { get; internal set; }
        public SD_SingleItemDescriptionPage SD_SingleItemDescriptionPage { get; internal set; }

        public SD_YourInfoPage SD_YourInfoPage { get; internal set; }

        public SD_LoginPage SD_LoginPage { get; internal set; }


        public SD_Website(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 10)
        {
            //Instantiating the driver
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;

            //Instantiate page objects with the selenium driver
            SD_HomePage = new SD_HomePage(SeleniumDriver);
            SD_Cart = new SD_Cart(SeleniumDriver);
            SD_CheckoutPage1 = new SD_CheckoutPage1(SeleniumDriver);
            SD_CheckoutPage2 = new SD_CheckoutPage2(SeleniumDriver);

            SD_SingleItemDescriptionPage = new SD_SingleItemDescriptionPage(SeleniumDriver);
            



            SD_YourInfoPage = new SD_YourInfoPage(SeleniumDriver);

            SD_LoginPage = new SD_LoginPage(SeleniumDriver);

        }

        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }

        public string GetURL()
        {
            return SeleniumDriver.Url;
        }
    }
}
