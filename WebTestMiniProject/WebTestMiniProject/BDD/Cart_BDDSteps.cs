using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;

namespace WebTestProject
{
    [Binding]
    public class Cart_BDDSteps
    {
        public SD_Website SD_Website { get; } = new SD_Website("chrome");

        [Given(@"I am on the cart page")]
        public void GivenIAmOnTheCartPage()
        {
            SD_Website.SD_LoginPage.VisitLoginPage();
            SD_Website.SD_LoginPage.EnterUsername("standard_user");
            SD_Website.SD_LoginPage.EnterPassword("secret_sauce");
            SD_Website.SD_LoginPage.ClickLoginButton();
            Thread.Sleep(3000);
            SD_Website.SD_HomePage.ClickCart();
            Thread.Sleep(3000);
        }

        [Given(@"I am on the cart page with items")]
        public void GivenIAmOnTheCartPageWithItems()
        {
            SD_Website.SD_LoginPage.VisitLoginPage();
            SD_Website.SD_LoginPage.EnterUsername("standard_user");
            SD_Website.SD_LoginPage.EnterPassword("secret_sauce");            
            SD_Website.SD_LoginPage.ClickLoginButton();
            Thread.Sleep(3000);
            SD_Website.SD_HomePage.AddItemToCart();
            SD_Website.SD_HomePage.ClickCart();
            Thread.Sleep(3000);
        }


        [Given(@"I have no items in my cart")]
        public void GivenIHaveNoItemsInMyCart()
        {
            Assert.That(SD_Website.SD_Cart.CheckThereIsAnItemInTheCart(), Is.Null);
        }
        
        [Given(@"I have items in my cart")]
        public void GivenIHaveItemsInMyCart()
        {
            Assert.That(SD_Website.SD_Cart.CheckThereIsAnItemInTheCart(), Is.Not.Null);
        }
        
        [When(@"I press the continue shopping button")]
        public void WhenIPressTheContinueShoppingButton()
        {
            SD_Website.SD_Cart.ClickContinueShoppingButton();
        }
        
        [When(@"I press the checkout button")]
        public void WhenIPressTheCheckoutButton()
        {
            SD_Website.SD_Cart.ClickCheckoutButton();
        }
        
        [Then(@"I should land on the ""(.*)"" page")]
        public void ThenIShouldLandOnThePage(string pageURL)
        {
            Assert.That(SD_Website.GetURL(), Does.Contain(pageURL));
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
