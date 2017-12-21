using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EcommerceAutomationPracticeTests.PageObjects
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        internal void VisitLoginPage()
        {
            string visitStoreLoginPageURL = "";
            Visit(visitStoreLoginPageURL);
            By SignInLink = By.ClassName("login");
            WaitUntilClickable(SignInLink, WAIT_SECONDS);
            Click(SignInLink);
        }

        internal void VisitHomePage()
        {
            string visitHomePageURL = "";
            Visit(visitHomePageURL);
            By HomePageLink = By.CssSelector("[href='http://automationpractice.com/']");
            WaitUntilClickable(HomePageLink, WAIT_SECONDS);
            Click(HomePageLink);
        }


        internal void AddItemToCart()
        {
            By ListItemOnHomePage = By.ClassName("content_price");
            Hover(Find(ListItemOnHomePage));
            WaitUntilDisplayed(ListItemOnHomePage, WAIT_SECONDS);
            By AddItemToCartButton = By.CssSelector("[data-id-product='1']");
            WaitUntilDisplayed(AddItemToCartButton, WAIT_SECONDS);
            Click(AddItemToCartButton);
        }

        //internal void AddItemToCart()
        //{ // must use CssSelector in this case because of many products on the same page, classes for buttons identical, and data-id is not an actual id
        //    By AddItemToCartButton = By.CssSelector("[data-id-product='1']");
        //    WaitUntilDisplayed(AddItemToCartButton, WAIT_SECONDS);
        //    Click(AddItemToCartButton);
        //}

        internal void ItemSuccessfullyAdded()
        {
            By CheckMarkIcon = By.ClassName("icon-ok");
            WaitUntilDisplayed(CheckMarkIcon, WAIT_SECONDS);
            Find(CheckMarkIcon);
        }

        internal void ProceedToCheckout()
        {
            By ProceedToCheckoutButton = By.CssSelector("[href='http://automationpractice.com/index.php?controller=order']");
            WaitUntilClickable(ProceedToCheckoutButton, WAIT_SECONDS);
            Click(ProceedToCheckoutButton);
        }

        internal void ViewShoppingCart()
        {
            string viewShoppingCartURL = "";
            Visit(viewShoppingCartURL);
            By ShoppingCartPageTitle = By.Id("cart-title");
            WaitUntilDisplayed(ShoppingCartPageTitle, WAIT_SECONDS);
            Find(ShoppingCartPageTitle);
        }
    }
}
