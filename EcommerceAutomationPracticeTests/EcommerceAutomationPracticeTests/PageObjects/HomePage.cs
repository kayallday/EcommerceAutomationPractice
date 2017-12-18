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
    }
}
