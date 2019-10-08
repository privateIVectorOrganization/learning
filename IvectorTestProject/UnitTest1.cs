using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using IvectorTestProject;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = Driver.driver;
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://training.ivector.co.uk";
            Thread.Sleep(3000);
            LoginPage login = new LoginPage();
            PageFactory.InitElements(driver, login);
            login.Login();

            System.Console.WriteLine("lefutott");
            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}