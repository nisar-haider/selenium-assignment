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
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Security.Cryptography;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Windows;
using System.Xml;
using System.Net;
using OpenQA.Selenium.Remote;


namespace selenium_assignment
{
    public class Ebay
    {
        public static IWebDriver driver;
           
        [OneTimeSetUp]
        public void Setup()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\Users\Duraze\Documents\Selenium-assignment\selenium-assignment\bin\Debug\netcoreapp3.1");
            driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com/";
            driver.Manage().Window.Maximize();
            
        }

        [OneTimeTearDown]
        public void close()
        {
            driver.Close();
        }

        public void PrintResults(int result)
        {
            EbayHome ebayHome=new EbayHome(driver);
            EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
            //Asynchronus wait initialized
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            for(int i=0; i<result; i++)
                {
                    Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[i].Text + "\n");
                }


        }

 
        public void PrintNthResult(int value)
        {
            EbayHome ebayHome=new EbayHome(driver);
            EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
            //Asynchronus wait initialized
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            
            Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[value].Text + "\n");
                
        }
           [Test]
           public void EbayWebsite()
           {
                EbayHome ebayHome=new EbayHome(driver);
                EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
                //Asynchronus wait initialized
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
               
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(ebayHome.searchField));
                Assert.IsTrue(ebayHome.exists_searchField());
                ebayHome.searchInput("Apple Watches");
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(ebayHome.btn_AllCategories));
                Assert.IsTrue(ebayHome.exists_btn_AllCategories());
                driver.FindElement(ebayHome.btn_AllCategories).Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ebayHome.category_ConsumerElectronics));
                Assert.IsTrue(ebayHome.exists_category_ConsumerElectronics());
                driver.FindElement(ebayHome.category_ConsumerElectronics).Click();


                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ebayHome.btn_Search));
                Assert.IsTrue(ebayHome.exists_btn_Search());
                driver.FindElement(ebayHome.btn_Search).Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ebaySearchResult.searchCount));
                Assert.IsTrue(ebaySearchResult.exists_searchCount());
                int resultCount=driver.FindElements(ebaySearchResult.resultTitle).Count();

                Console.WriteLine(resultCount);
                System.Threading.Thread.Sleep(3000);

                IWebElement Element = driver.FindElement(By.XPath("//div[@class='srp-river-results clearfix']/ul/li/div/div[2]/a/h3[text()='For Apple Watch Case 38 40 42 44MM SE 6 5 4 3 2Bling Diamond Protector For Women']"));

                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

                int resultCount1=driver.FindElements(ebaySearchResult.resultTitle).Count();

                Console.WriteLine(resultCount1);

                PrintResults(resultCount);

                PrintNthResult(4);

        
        
                System.Threading.Thread.Sleep(3000);  
                

           }
    }
}
