using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IvectorTestProject
{
    public static class Driver
    {
        public static IWebDriver driver = new ChromeDriver(@"c:/Users/Desktop-PC/.nuget/packages/selenium.chrome.webdriver/76.0.0/driver/");
    }
}
