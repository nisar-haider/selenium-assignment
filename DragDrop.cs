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
    public class DragDrop
    {
        public static IWebDriver driver;
           
        [OneTimeSetUp]
        public void Setup()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\Users\Duraze\Documents\Selenium-assignment\selenium-assignment\bin\Debug\netcoreapp3.1");
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/droppable/";
            driver.Manage().Window.Maximize();
            
        }

        [OneTimeTearDown]
        public void close()
        {
            driver.Close();
        }

        [Test]
        public void DragDropTest()
        {
            Dropabble dropabble=new Dropabble(driver);
            //Asynchronus wait initialized
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='demo-frame']")));
            //Element which needs to drag.    		
        	IWebElement From=driver.FindElement(dropabble.From);
            //Element on which need to drop.		
            IWebElement To=driver.FindElement(dropabble.To);					
         		
            //Using Action class for drag and drop.		
            Actions act=new Actions(driver);					

	        //Dragged and dropped.		
            act.DragAndDrop(From, To).Build().Perform();

             wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(dropabble.txt_Dropped));
            Assert.IsTrue(dropabble.exists_txt_Dropped());	

            driver.SwitchTo().DefaultContent();


            System.Threading.Thread.Sleep(4000);
        }
         
        
    }
}
