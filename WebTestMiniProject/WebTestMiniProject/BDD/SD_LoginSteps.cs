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


        [AfterScenario]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}
