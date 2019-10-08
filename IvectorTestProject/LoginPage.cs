using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace IvectorTestProject
{
    class LoginPage
    {

            [FindsBy(How = How.Id, Using = "txtEmail")]
            IWebElement EmailAddressInput { get; set; }

            [FindsBy(How = How.Id, Using = "txtPassword")]
            IWebElement PasswordInput { get; set; }

            [FindsBy(How = How.Id, Using = "btnLogin")]
            IWebElement LoginButton { get; set; }

        //public LoginPage(IWebDriver driver)
        //{
        //    PageFactory.InitElements(driver, this);
        //}

        public void Login()
        {
            EmailAddressInput.SendKeys("Regression@intuitivesystems.co.uk");
            PasswordInput.SendKeys("Regression");
            LoginButton.Click();
            Thread.Sleep(3000);
        }

    }
}
