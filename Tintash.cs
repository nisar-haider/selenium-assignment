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
    public class Tintash:config.ConfigTintash
    {
       
           
           [Test]
           public void TintashWebsite()
           {
                Google google=new Google(driver);
                TThomePage tthomepage=new TThomePage(driver);
                Portfolio portfolio=new Portfolio(driver);
                Actions builder = new Actions(driver);
        
                //Asynchronus wait initialized
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
               
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(google.searchField));
                Assert.IsTrue(google.exists_searchField());
                google.searchInput("Tintash");

                System.Threading.Thread.Sleep(4000);
                int list = driver.FindElements(google.list_searchResult).Count();
                Console.WriteLine("Total no of suggestions in search box :: " +list);
                driver.FindElements(google.list_searchResult)[0].Click();
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(google.tintashLink));
                Assert.IsTrue(google.exists_tintashLink());
                driver.FindElement(google.tintashLink).Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(tthomepage.txt_BuildProducts));
                Assert.IsTrue(tthomepage.exists_txt_BuildProducts());

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(tthomepage.btn_Portfolio));
                Assert.IsTrue(tthomepage.exists_btn_Portfolio());
                driver.FindElement(tthomepage.btn_Portfolio).Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.txt_Portfolio));
                Assert.IsTrue(portfolio.exists_txt_Portfolio());

                System.Threading.Thread.Sleep(3000);

                IWebElement Element = driver.FindElement(By.XPath("//span[text()='View Casestudy']"));

                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript("arguments[0].scrollIntoView();", Element);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.dd_Solution));
                Assert.IsTrue(portfolio.exists_dd_Solution());
                driver.FindElement(portfolio.dd_Solution).Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.chkbox_ddL_Solution));
                Assert.IsTrue(portfolio.exists_chkbox_ddL_Solution());
                driver.FindElement(portfolio.chkbox_ddL_Solution).Click();
                Assert.IsTrue(portfolio.isSelected_chkbox_ddL_Solution());

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.dd_Technology));
                Assert.IsTrue(portfolio.exists_dd_Technology());
                driver.FindElement(portfolio.dd_Technology).Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.chkbox_ddL_Technology));
                Assert.IsTrue(portfolio.exists_chkbox_ddL_Technology());
                driver.FindElement(portfolio.chkbox_ddL_Technology).Click();
                Assert.IsTrue(portfolio.isSelected_chkbox_ddL_Technology());

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.dd_Industry));
                Assert.IsTrue(portfolio.exists_dd_Industry());
                driver.FindElement(portfolio.dd_Industry).Click();

                System.Threading.Thread.Sleep(3000);

                IWebElement Element1 = driver.FindElement(By.XPath("//*[text()='Retail & eCommerce']"));

                IJavaScriptExecutor js1 = driver as IJavaScriptExecutor;
                js1.ExecuteScript("arguments[0].scrollIntoView();", Element1);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.chkbox_ddL_Industry));
                Assert.IsTrue(portfolio.exists_chkbox_ddL_Industry());
                System.Threading.Thread.Sleep(2000);
                driver.FindElement(portfolio.chkbox_ddL_Industry).Click();
                Assert.IsTrue(portfolio.isSelected_chkbox_ddL_Industry());

                IWebElement Element2 = driver.FindElement(By.XPath("//*[contains(text(),'Camaradly is an employee-first')]"));

                IJavaScriptExecutor js2 = driver as IJavaScriptExecutor;
                js2.ExecuteScript("arguments[0].scrollIntoView();", Element2);
                System.Threading.Thread.Sleep(2000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(portfolio.txt_Camaradly));
                Assert.IsTrue(portfolio.exists_txt_Camaradly());
        
                System.Threading.Thread.Sleep(3000);  
                

           }
    }
}
