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

        public void PrintResults()
        {
            EbayHome ebayHome=new EbayHome(driver);
            EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
            //Asynchronus wait initialized
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ebaySearchResult.searchCount));
            Assert.IsTrue(ebaySearchResult.exists_searchCount());
            int resultCount=driver.FindElements(ebaySearchResult.resultTitle).Count();

            for(int i=0; i<resultCount; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[i].Text + "\n");
                }
            IJavaScriptExecutor js1 = driver as IJavaScriptExecutor;
            js1.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            System.Threading.Thread.Sleep(3000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ebaySearchResult.btn_NextPage));
            Assert.IsTrue(ebaySearchResult.exists_btn_NextPage());
            driver.FindElement(ebaySearchResult.btn_NextPage).Click();
            int resultCount1=driver.FindElements(ebaySearchResult.resultTitle).Count();

            for(int i=0; i<resultCount1; i++)
                {
                    Console.WriteLine(resultCount+i);
                    Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[i].Text + "\n");
                }




        }

 
        public void PrintNthResult(int value)
        {
            EbayHome ebayHome=new EbayHome(driver);
            EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
            //Asynchronus wait initialized
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));

            int result=driver.FindElements(ebaySearchResult.resultTitle).Count();

            if(value<=result)
            {
                Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[value].Text + "\n");
            }

            else{
                Console.WriteLine("Index out of bound. Please enter a lesser value");
            }
            
            
                
        }
        
        public void PrintItemsPerPage()
        {
            EbayHome ebayHome=new EbayHome(driver);
            EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
            //Asynchronus wait initialized
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ebaySearchResult.itemsPerPage));
                Assert.IsTrue(ebaySearchResult.exists_itemsPerPage());

                var getItemsPerPage=driver.FindElement(ebaySearchResult.itemsPerPage).Text;
                int items= int.Parse(getItemsPerPage);
                
                Console.WriteLine(items);

            for(int i=0; i<items; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[i].Text + "\n");
            }

            
                
        }

        public void PrintResultsWhileScrolling()
       
            {
                EbayHome ebayHome=new EbayHome(driver);
                EbaySearchResult ebaySearchResult=new EbaySearchResult(driver);
        
                //Asynchronus wait initialized
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                int resultCount=driver.FindElements(ebaySearchResult.resultTitle).Count();

                Console.WriteLine(resultCount);
                for(int i=0; i<resultCount; i++)
                {
                    IWebElement Element = driver.FindElements(By.XPath("//div[@class='srp-river-results clearfix']/ul/li"))[i];

                    IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    js.ExecuteScript("arguments[0].scrollIntoView();",Element);
                    Console.WriteLine(i);
                    Console.WriteLine("Product name= " + driver.FindElements(ebaySearchResult.resultTitle)[i].Text + "\n");
                }


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
                
                //Console.WriteLine(resultCount1);

                //PrintResults();

               // PrintNthResult(200);

                
                
                //PrintItemsPerPage(items);
                PrintResultsWhileScrolling();
        
        
                System.Threading.Thread.Sleep(3000);  
                

           }
    }
}
