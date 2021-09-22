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
    class EbayHome
    {
        private IWebDriver _driver;

        public EbayHome(IWebDriver driver)
        {
            _driver = driver;
        }


        public By searchField=By.XPath("//input[@type='text']");
        public By btn_AllCategories=By.XPath("//div[@id='gh-cat-box']/child::select");
        public By category_ConsumerElectronics=By.XPath("//div[@id='gh-cat-box']/child::select/child::option[text()='Consumer Electronics']");
        public By btn_Search=By.XPath("//input[@class='btn btn-prim gh-spr']");
    

        //Fuctions to test if elements are being displayed 
        public bool exists_searchField()
        {
            return _driver.FindElement(searchField).Displayed;
        }
        public bool exists_btn_AllCategories()
        {
            return _driver.FindElement(btn_AllCategories).Displayed;
        }
        public bool exists_category_ConsumerElectronics()
        {
            return _driver.FindElement(category_ConsumerElectronics).Displayed;
        }
        public bool exists_btn_Search()
        {
            return _driver.FindElement(btn_Search).Displayed;
        }
       
        
        public void searchInput(string input)
        {
            _driver.FindElement(searchField).SendKeys(input);
        }
       
       

    }
}