﻿

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumFirstTest
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); 
            // This line of code will create an object of DriverManager which will automatically
            // download the latest chromeDriver.exe which co-aligns with the version of the chrome browser installed in your machine.
            DriverManager driverManager = new DriverManager();
            driverManager.SetUpDriver(new ChromeConfig());
            // this line of code of will instantiate the chromedriver object which can be manipulate to target the elements on the webpage.
            driver = new ChromeDriver();

            //To manage the window size to full screen
            driver.Manage().Window.Maximize();


        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            // TestContext.Progress.WriteLine(driver.PageSource); // gives the sourcecode of the html page.
            // driver.Close(); // close 1 windows the original one.
            // driver.Quit(); // closes all the windows.

            
       
        }

        [TearDown]
        public void ClosedBrowser()
        {

        }

    }
}
