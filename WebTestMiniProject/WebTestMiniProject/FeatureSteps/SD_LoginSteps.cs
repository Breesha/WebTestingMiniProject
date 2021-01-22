using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace WebTestProject
{
    [Binding]
    public class SD_LoginSteps
    {
        public SD_Website SD_Website { get; } = new SD_Website("chrome");

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            SD_Website.SD_LoginPage.VisitLoginPage();
        }

        [When(@"I enter an username ""(.*)""")]
        public void WhenIEnterAnUsername(string username)
        {
            SD_Website.SD_LoginPage.EnterUsername(username);
        }

        [When(@"I enter a password ""(.*)""")]
        public void WhenIEnterAPassword(string password)
        {
            SD_Website.SD_LoginPage.EnterPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            SD_Website.SD_LoginPage.ClickLoginButton();
        }

        [When(@"I click the backpack label link")]
        public void WhenIClickTheBackpackLabelLink()
        {
            SD_Website.SD_LoginPage.ClickBackPackLabel();
        }

        [Then(@"I should see an error message containing ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessageContaining(string expected)
        {
            Assert.That(SD_Website.SD_LoginPage.ErrorMessage(), Does.Contain(expected));
        }

        [Then(@"I should land on the products page where the url is ""(.*)""")]
        public void ThenIShouldLandOnTheProductsPageWhereTheUrlIs(string expected)
        {
            Assert.That(SD_Website.SD_LoginPage.GetPageURL(), Is.EqualTo(expected));
        }

        [Then(@"I click on the login button and should land on the products page after (.*) seconds")]
        public void ThenIClickOnTheLoginButtonAndShouldLandOnTheProductsPageAfterSeconds(int expected)
        {
            Assert.That(SD_Website.SD_LoginPage.PageLoadTime(), Is.GreaterThan(expected));
        }

        [Then(@"I should land on the item page where the url is ""(.*)""")]
        public void ThenIShouldLandOnTheItemPageWhereTheUrlIs(string expected)
        {
            Assert.That(SD_Website.SD_LoginPage.GetPageURL(), Is.EqualTo(expected));
        }



        [AfterScenario]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}
