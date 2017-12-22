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
    class CheckoutSteps : BaseSteps
    {
        [BeforeScenario("Checkout")]
        public void BeforeCheckoutScenario()
        {
            LoadConfigValues();
            CheckBrowser();
        }

        [AfterScenario]
        public void AfterCheckoutScenario()
        {
            Driver.Quit();
        }

        [Given(@"I am on the Home page")]
        public void GivenIAmOnTheHomePage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.VisitHomePage();
        }

        //[Given(@"I hover over an item")]
        //public void GivenIHoverOverAnItem()
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    homePage.HoverOnItem();
        //}

        [When(@"I click Add to cart")]
        public void WhenIClickAddToCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddItemToCart();
        }

        [Then(@"an item is added to my cart")]
        public void ThenAnItemIsAddedToMyCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ItemSuccessfullyAdded();
        }

        [Given(@"I have added an item to the Cart")]
        public void GivenIHaveAddedAnItemToTheCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddItemToCart();
        }

        [When(@"I click Continue Shopping")]
        public void WhenIClickContinueShopping()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.ContinueShopping();
        }
        
        [Then(@"I no longer see my cart")]
        public void ThenINoLongerSeeMyCart()
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
