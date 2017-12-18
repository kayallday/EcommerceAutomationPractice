using System;
using NUnit;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EcommerceAutomationPracticeTests.PageObjects
{
    class LoginPage : BasePage
    {
        By emailAddress = By.Id("email");
        By passWord = By.Id("passwd");

        public LoginPage(IWebDriver driver) : base(driver) { }

        internal void CompleteLoginForm()
        {
            Type("automatedtestuseremail@gmail.com", Find(emailAddress));
            Type("AutomateEverything2319", Find(passWord));
        }

        internal void ClickLoginButton()
        {
            By SignInButton = By.Id("SubmitLogin");
            WaitUntilClickable(SignInButton, WAIT_SECONDS);
            Click(SignInButton);
        }

        internal void FindWelcomeMessage()
        {
            By WelcomeMessage = By.ClassName("info-account");
            WaitUntilDisplayed(WelcomeMessage, WAIT_SECONDS);
            Find(WelcomeMessage);
            //Assert.AreEqual("info-account", WelcomeMessage);
        }
    }
}