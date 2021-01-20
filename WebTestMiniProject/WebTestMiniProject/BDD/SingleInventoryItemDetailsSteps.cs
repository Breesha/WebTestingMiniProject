using System;
using TechTalk.SpecFlow;
using WebTestProject;

namespace WebTestMiniProject
{
    
    [Binding]
    public class SingleInventoryItemDetailsSteps
    {
        SD_Website SD_Website = new SD_Website("chrome");

        [Given(@"I am Logged in as a Standard")]
        public void GivenIAmLoggedInAsAStandard()
        {
            SD_Website.SD_SingleItemDescriptionPage.LogIn();
        }
        
        [When(@"I click on the inventory item with the (.*)")]
        public void WhenIClickOnTheInventoryItemWithThe(string id)
        {
            SD_Website.SD_SingleItemDescriptionPage.VisitSingleItemDetailsPage(id);
        }
        
        [Then(@"I can see that items details")]
        public void ThenICanSeeThatItemsDetails()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
