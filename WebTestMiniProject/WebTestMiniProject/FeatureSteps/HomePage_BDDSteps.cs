using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebTestProject;

namespace WebTestMiniProject.BDD
{
    [Binding]
    public class HomePage_BDDSteps
    {
        public SD_Website SD_Website { get; } = new SD_Website("chrome");

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            SD_Website.SD_LoginPage.VisitLoginPage();
            SD_Website.SD_LoginPage.EnterUsername("standard_user");
            SD_Website.SD_LoginPage.EnterPassword("secret_sauce");
            SD_Website.SD_LoginPage.ClickLoginButton();
            Thread.Sleep(1000);
        }
        
        [When(@"I add an item to my cart")]
        public void WhenIAddAnItemToMyCart()
        {
            SD_Website.SD_HomePage.AddItemToCart();
            Thread.Sleep(1000);
        }
        
        [Then(@"I should have (.*) item in the cart")]
        public void ThenIShouldHaveItemInTheCart(int noOfItems)
        {
            Assert.That(SD_Website.SD_HomePage.GetNumberOfItemsInCart(), Is.EqualTo(noOfItems));
        }

        [When(@"I go to the cart page")]
        public void WhenIGoToTheCartPage()
        {
            SD_Website.SD_HomePage.ClickCart();
        }

        [Then(@"There should be an item in the cart")]
        public void ThenThereShouldBeAnItemInTheCart()
        {
            Assert.That(SD_Website.SD_Cart.CheckThereIsAnItemInTheCart(), Is.Not.Null);
        }

        [Then(@"The button text should have changed to ""(.*)""")]
        public void ThenTheButtonTextShouldHaveChangedTo(string btnText)
        {
            Assert.That(SD_Website.SD_HomePage.GetButtonText(), Is.EqualTo(btnText));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            //Quit this driver, closing every associated window
            SD_Website.SeleniumDriver.Quit();
            //Releases unmanaged resources
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}
