using System;
using TechTalk.SpecFlow;
using WebTestProject;
using NUnit.Framework;
using System.Threading;

namespace WebTestMiniProject
{
    
    [Binding]
    public class SingleInventoryItemDetailsSteps
    {
        SD_Website SD_Website = new SD_Website("chrome");
        public int cartCounter { get; set; }

        [Given(@"I am Logged in as a Standard")]
        public void GivenIAmLoggedInAsAStandard()
        {
            SD_Website.SD_SingleItemDescriptionPage.VisitHomePage();
            SD_Website.SD_LoginPage.EnterUsername("standard_user");
            SD_Website.SD_LoginPage.EnterPassword("secret_sauce");
            SD_Website.SD_LoginPage.ClickLoginButton();
        }
        
        [When(@"I click on the inventory item with the (.*)")]
        public void WhenIClickOnTheInventoryItemWithThe(string id)
        {
            SD_Website.SD_SingleItemDescriptionPage.VisitSingleItemDetailsPage(id);
        }
        
      
        [Then(@"I can see that items (.*) details")]
        public void ThenICanSeeThatItemsDetails(string id)
        {
            var currentURL = SD_Website.SD_SingleItemDescriptionPage.GetCurrentPagesURL();
            Assert.That(currentURL, Is.EqualTo($"https://www.saucedemo.com/inventory-item.html?id={id[5]}"));
        }

        [Given(@"I am on an item's (.*) description page")]
        public void GivenIAmOnAnItemSDescriptionPage(string id)
        {
            SD_Website.SD_SingleItemDescriptionPage.VisitSingleItemDetailsPage(id);
        }

        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string p0)
        {
            SD_Website.SD_SingleItemDescriptionPage.GoToProductsList();
        }

        [Then(@"I am redirected to the products page")]
        public void ThenIAmRedirectedToTheProductsPage()
        {
            var currentURL = SD_Website.SD_SingleItemDescriptionPage.GetCurrentPagesURL();
            Assert.That(currentURL, Is.EqualTo($"https://www.saucedemo.com/inventory.html"));
        }

        [When(@"I click the Add to Cart button")]
        public void WhenIClickTheAddToCartButton()
        {
            cartCounter = SD_Website.SD_SingleItemDescriptionPage.GetCartCounter();
            SD_Website.SD_SingleItemDescriptionPage.ClickCartButton();
        }

        [Then(@"the item amount in my cart increases by (.*)")]
        public void ThenTheItemAmountInMyCartIncreasesBy(int number)
        {
            int newCounter = SD_Website.SD_SingleItemDescriptionPage.GetCartCounter();
            Assert.That(cartCounter + number, Is.EqualTo(newCounter));

        }
        [Then(@"Then the ""(.*)"" buttons name is ""(.*)""")]
        public void ThenThenTheButtonsNameIs(string p0, string cartButtonText)
        {
            Assert.That(SD_Website.SD_SingleItemDescriptionPage.GetInventoryCartButtnText(), Is.EqualTo(cartButtonText));
           
        }
        [Given(@"I add an item in my cart")]
        public void GivenIAddAnItemInMyCart()
        {
            SD_Website.SD_SingleItemDescriptionPage.ClickCartButton();
            cartCounter = SD_Website.SD_SingleItemDescriptionPage.GetCartCounter();
        }

        [When(@"I click the REMOVE button")]
        public void WhenIClickTheREMOVEButton()
        {
            SD_Website.SD_SingleItemDescriptionPage.ClickCartButton();
            Thread.Sleep(2000);
        }

        [Then(@"the item amount in my cart decreases by (.*)")]
        public void ThenTheItemAmountInMyCartDecreasesBy(int number)
        {
            int newCounter = SD_Website.SD_SingleItemDescriptionPage.GetCartCounter();
            Assert.That(cartCounter - number, Is.EqualTo(newCounter));
            Thread.Sleep(2000);
        }






        [AfterScenario]
        public void Teardown()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }

    }
}
