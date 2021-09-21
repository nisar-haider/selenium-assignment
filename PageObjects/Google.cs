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
    class Google
    {
        private IWebDriver _driver;

        public Google(IWebDriver driver)
        {
            _driver = driver;
        }


        public By searchField=By.XPath("//*[@title='Search']");
        public By list_searchResult=By.XPath("//ul[@role ='listbox']//li");
        public By tintashLink=By.XPath("//*[text()='Tintash - Stanford Alumni Led Web & App Development ...']");
    

        //Fuctions to test if elements are being displayed 
        public bool exists_searchField()
        {
            return _driver.FindElement(searchField).Displayed;
        }
        public bool exists_list_searchResult()
        {
            return _driver.FindElement(list_searchResult).Displayed;
        }
        public bool exists_tintashLink()
        {
            return _driver.FindElement(tintashLink).Displayed;
        }
       
        
        public void searchInput(string input)
        {
            _driver.FindElement(searchField).SendKeys(input);
        }
       
       

    }
}