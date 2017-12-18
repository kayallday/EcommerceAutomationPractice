using System;
using OpenQA.Selenium;

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
            throw new NotImplementedException();
        }
    }
}