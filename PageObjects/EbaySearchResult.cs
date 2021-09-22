using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace selenium_assignment.PageObjects
{
    class EbaySearchResult
    {
        private IWebDriver _driver;

        public EbaySearchResult(IWebDriver driver)
        {
            _driver = driver;
        }


        public By searchCount=By.XPath("//div[@class='srp-controls__control srp-controls__count']/h1/span");
        public By searchList=By.XPath("//div[@class='srp-river-results clearfix']/ul/li");
        public By resultTitle=By.XPath("//div[@class='srp-river-results clearfix']/ul/li/div/div[2]/a/h3[@class='s-item__title']");
        public By itemsPerPage=By.XPath("//span[@id='srp-ipp-menu']/button/span/span");

        //Fuctions to test if elements are being displayed 
        public bool exists_searchList()
        {
            return _driver.FindElement(searchList).Displayed;
        }
        public bool exists_searchCount()
        {
            return _driver.FindElement(searchCount).Displayed;
        }
        public bool exists_resultTitle()
        {
            return _driver.FindElement(resultTitle).Displayed;
        }
        public bool exists_itemsPerPage()
        {
            return _driver.FindElement(itemsPerPage).Displayed;
        }
        
       
       

    }
}