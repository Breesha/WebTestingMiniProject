using NUnit.Framework;
using System.Threading;

namespace WebTestProject
{
    class YourInfoTests
    {
        public SD_Website SD_Website { get; } = new SD_Website("Chrome");

        [Test]
        public void GivenIAmOnTheYourInfopage_WhenIEnterMyDetails_ThenTheFieldsUpdate()
        {
            SD_Website.SD_YourInfoPage.VisitYourInfoPage();
            SD_Website.SD_YourInfoPage.InputFirstName("Breesha");
            SD_Website.SD_YourInfoPage.InputLastName("Foxton");
            SD_Website.SD_YourInfoPage.InputPostalCode("IM2");
            Assert.That(SD_Website.SD_YourInfoPage.GetPageTitle(), Does.Contain("Swag Labs"));
        }

        [Test]
        public void GivenIAmOnTheYourInfopage_ANdIEnterMyDetails_WhenIClickContinue_ThenIGoToTheCheckoutPage()
        {
            SD_Website.SD_YourInfoPage.VisitYourInfoPage();
            SD_Website.SD_YourInfoPage.InputFirstName("Breesha");
            SD_Website.SD_YourInfoPage.InputLastName("Foxton");
            SD_Website.SD_YourInfoPage.InputPostalCode("IM2");
            SD_Website.SD_YourInfoPage.ClickContinue();
            Assert.That(SD_Website.SD_YourInfoPage.GetPageURL(), Does.Contain("https://www.saucedemo.com/checkout-step-two.html"));
        }

        [Test]
        public void GivenIAmOnTheYourInfopage_WhenIClickCancel_ThenIGoBackToTheCartPage()
        {
            SD_Website.SD_YourInfoPage.VisitYourInfoPage();
            SD_Website.SD_YourInfoPage.ClickCancel();
            Assert.That(SD_Website.SD_YourInfoPage.GetPageURL(), Does.Contain("https://www.saucedemo.com/cart.html"));
        }

        [Test]
        public void GivenIAmOnTheYourInfopage_WhenIClickContinue_ThenIGetAnErrorMessage()
        {
            SD_Website.SD_YourInfoPage.VisitYourInfoPage();
            SD_Website.SD_YourInfoPage.ClickContinue();
            Thread.Sleep(2000);
            Assert.That(SD_Website.SD_YourInfoPage.GetErrorMessage(), Does.Contain("Error: First Name is required"));
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            //Quit this driver, closing every assocciated window
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();

        }
    }
}
