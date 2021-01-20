using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace WebTestProject
{
    public class SeleniumDriverConfig
    {
        //Property for the driver for later use
        public IWebDriver Driver { get; set; }

        //Constructor that calls a method to set up the driver depending on the type of browserr we want
        public SeleniumDriverConfig(string driver, int pageLoadsInSecs, int implicitWaitInSecs)
        {
            //Method that sets up the driver. We can pass in the driver type
            DriverSetUp(driver, pageLoadsInSecs, implicitWaitInSecs);
        }

        //This method will trigger another method that sets the driver configuration depending on the browser type
        public void DriverSetUp(string driverName, int pageLoadsInSecs, int implicitWaitInSecs)
        {
            if (driverName.ToLower() == "chrome")
            {
                //This method creates the new driver instance that we can use in our testing
                SetChromeDriver();
                //Method will set the config of the driver
                SetDriverConfiguration(pageLoadsInSecs, implicitWaitInSecs);
            }
            else if (driverName.ToLower() == "firefox")
            {
                //This method creates the new driver instance that we can use in our testing
                SetFireFoxDriver();
                //Method will set the config of the driver
                SetDriverConfiguration(pageLoadsInSecs, implicitWaitInSecs);
            }
        }

        private void SetDriverConfiguration(int pageLoadsInSecs, int implicitWaitInSecs)
        {
            //Time driver will wait for page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadsInSecs);
            //Time driver waits for element before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }

        private void SetFireFoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        private void SetChromeDriver()
        {
            Driver = new ChromeDriver();
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
        }
    }
}
