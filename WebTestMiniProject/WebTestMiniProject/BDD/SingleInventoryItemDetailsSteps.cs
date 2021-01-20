using System;
using TechTalk.SpecFlow;
using WebTestProject;
using NUnit.Framework;

namespace WebTestMiniProject
{
    
    [Binding]
    public class SingleInventoryItemDetailsSteps
    {
        SD_Website SD_Website = new SD_Website("chrome");

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

        [AfterScenario]
        public void Teardown()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }

    }
}
