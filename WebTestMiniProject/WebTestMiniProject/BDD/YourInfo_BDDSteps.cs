using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace WebTestProject
{
    [Binding]
    public class YourInfo_BDDSteps
    {

        public SD_Website SD_Website { get; } = new SD_Website("chrome");

        [Given(@"I am on the Your Information page")]
        public void GivenIAmOnTheYourInformationPage()
        {
            SD_Website.SD_YourInfoPage.VisitYourInfoPage();
        }

        [Given(@"the (.*), (.*) and (.*) are entered")]
        public void GivenTheAndAreEntered(string firstName, string lastName, string postalCode)
        {
            SD_Website.SD_YourInfoPage.InputFirstName(firstName);
            SD_Website.SD_YourInfoPage.InputLastName(lastName);
            SD_Website.SD_YourInfoPage.InputPostalCode(postalCode);
        }

        [Given(@"the fields are empty")]
        public void GivenTheFieldsAreEmpty() { }

        
        [When(@"the continue button is clicked")]
        public void WhenTheContinueButtonIsClicked()
        {
            SD_Website.SD_YourInfoPage.ClickContinue();
        }

        [When(@"the cancel button is clicked")]
        public void WhenTheCancelButtonIsClicked()
        {
            SD_Website.SD_YourInfoPage.ClickCancel();
        }


        [Then(@"the page url will be ""(.*)""")]
        public void ThenThePageUrlWillBe(string url)
        {
            Assert.That(SD_Website.SD_YourInfoPage.GetPageURL(), Does.Contain(url)); ;
        }

        [Then(@"the error message will say ""(.*)""")]
        public void ThenTheErrorMessageWillSay(string expected)
        {
            Assert.That(SD_Website.SD_YourInfoPage.GetErrorMessage(), Does.Contain(expected));
        }

        [Then(@"the following error message will say (.*)")]
        public void ThenTheFollowingErrorMessageWillSay(string expected)
        {
            Assert.That(SD_Website.SD_YourInfoPage.GetErrorMessage(), Does.Contain(expected));
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            //Quits this driver, closing every associated window.
            SD_Website.SeleniumDriver.Quit();
            //Releases unmanaged resources
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}
