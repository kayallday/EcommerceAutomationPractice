using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EcommerceAutomationPracticeTests.PageObjects
{
    class HomePage : BasePage
    {
        public bool? IsVisible { get; private set; }

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
            //Scroll to put the item in view of the web browser
            By ProductContainer = By.Id("homefeatured");
            ScrollToView(Find(ProductContainer));
            //Hover over the item to display the add to cart button
            By ListItemOnHomePage = By.CssSelector("#homefeatured > li.ajax_block_product.col-xs-12.col-sm-4.col-md-3.first-in-line.first-item-of-tablet-line.first-item-of-mobile-line:first-child");
            Hover(Find(ListItemOnHomePage));
            WaitUntilDisplayed(ListItemOnHomePage, WAIT_SECONDS);
            By AddItemToCartButton = By.CssSelector("[data-id-product='1']");
            WaitUntilDisplayed(AddItemToCartButton, WAIT_SECONDS);
            Click(AddItemToCartButton);
        }

        internal void VisitShoppingCartPage()
        {
            throw new NotImplementedException();
        }

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
