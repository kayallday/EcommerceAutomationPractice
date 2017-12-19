using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EcommerceAutomationPracticeTests.StepDefinitions
{
    class CheckoutSteps
    {
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {

        }

        [Given(@"I am on the Home page")]
        public void GivenIAmOnTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have added an item to the Cart")]
        public void GivenIHaveAddedAnItemToTheCart()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Proceed to checkout")]
        public void WhenIClickProceedToCheckout()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I can view the items in my Shopping Cart")]
        public void ThenICanViewTheItemsInMyShoppingCart()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the Shopping-Cart Summary page")]
        public void GivenIAmOnTheShopping_CartSummaryPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have items in my cart")]
        public void GivenIHaveItemsInMyCart()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have proceeded through to the Shipping page")]
        public void GivenIHaveProceededThroughToTheShippingPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have agreed to the terms of Service")]
        public void GivenIHaveAgreedToTheTermsOfService()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I confirm my method of payment")]
        public void WhenIConfirmMyMethodOfPayment()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am taken to the confirmation page")]
        public void ThenIAmTakenToTheConfirmationPage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
