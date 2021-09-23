using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using selenium_assignment.PageObjects;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.Windows;
using System.Xml;
using System.Net;
using OpenQA.Selenium.Remote;
using NUnit.Framework.Interfaces;


namespace selenium_assignment.config
{
    public class ConfigTintash
    {
        public static IWebDriver driver;
        public string reportPath;
        protected string currDir = System.IO.Directory.GetCurrentDirectory();
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentReports feature;
        public static ExtentTest test;

        [OneTimeSetUp]
        public void BeforeSuite()
        {
           string reportTime = DateTime.Now.ToString("dd-MM-yyy-HH-mm-ss");
            reportPath=currDir.Replace("\\bin\\Debug\\netcoreapp3.1", "\\ExtentReports\\");
            extent=new AventStack.ExtentReports.ExtentReports();
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(reportPath + "Test Report_" + reportTime + ".html");
            extent.AttachReporter(htmlReporter);
            
        }

        [SetUp]
        public void BeforeTest()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\Users\Duraze\Documents\Selenium-assignment\selenium-assignment\bin\Debug\netcoreapp3.1");
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\Users\Duraze\Documents\Selenium-assignment\selenium-assignment\bin\Debug\netcoreapp3.1");
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
            

        [TearDown]
        public void AfterScenario()
        {
            
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var Title = "" + TestContext.CurrentContext.Test.Name + "";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            Status testStatus;

            
            switch(status)
            {
                case TestStatus.Failed:

                    testStatus = Status.Fail;
                    test.Log(testStatus, "Test ended with " + testStatus + " – " + errorMessage);
                    break;
                case TestStatus.Passed:
                        testStatus = Status.Pass;
                        test.Log(testStatus, "Test ended with " + testStatus);
                        break;
                    default:
                        testStatus = Status.Info;
                        test.Log(testStatus, "Test ended with " + testStatus);
                        break;

            }

            driver.Quit();
        }

        [OneTimeTearDown]
        public void afterFeature()
        {
            extent.Flush();
            
        }

           
       
    }
}
