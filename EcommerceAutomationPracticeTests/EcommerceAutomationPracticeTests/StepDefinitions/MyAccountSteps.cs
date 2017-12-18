using EcommerceAutomationPracticeTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EcommerceAutomationPracticeTests.StepDefinitions
{
    [Binding]
    class MyAccountSteps : BaseSteps
    {
        [BeforeScenario("Login")]
        public void BeforeLoginScenario()
        {
            LoadConfigValues();
            CheckBrowser();
        }

        [AfterScenario]
        public void AfterLoginScenario()
        {
            Driver.Quit();
        }

        [Given(@"I am on the Login Page")]
        public void GivenIAmOnTheLoginPage()
        {
            HomePage homepage = new HomePage(Driver);
            homepage.VisitLoginPage();
        }

        [Given(@"I enter valid credentials")]
        public void GivenIEnterValidCredentials()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.CompleteLoginForm();
        }

        [When(@"I click the Sign in button")]
        public void WhenIClickTheSignInButton()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.ClickLoginButton();
        }

        [Then(@"Can view the My Account page")]
        public void ThenCanViewTheMyAccountPage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
