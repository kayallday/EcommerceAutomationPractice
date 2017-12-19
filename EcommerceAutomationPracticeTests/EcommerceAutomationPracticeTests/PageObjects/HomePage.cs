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
            By HomePageLink = By.Id("header_logo");
            WaitUntilClickable(HomePageLink, WAIT_SECONDS);
            Click(HomePageLink);
        }

        internal void AddItemToCart()
        { // must use CssSelector in this case because of many products on the same page, classes for buttons identical, and data-id is not an actual id
            By AddItemToCartButton = By.CssSelector("[data-id-product='1']");
            WaitUntilClickable(AddItemToCartButton, WAIT_SECONDS);
            Click(AddItemToCartButton);
        }
    }
}
