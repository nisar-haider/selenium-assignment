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
    class TThomePage
    {
        private IWebDriver _driver;

        public TThomePage(IWebDriver driver)
        {
            _driver = driver;
        }


        public By txt_BuildProducts=By.XPath("//*[text()='Build Products']");
        public By btn_Portfolio=By.XPath("//*[text()='Portfolio']");
        
        //Fuctions to test if elements are being displayed 
        public bool exists_txt_BuildProducts()
        {
            return _driver.FindElement(txt_BuildProducts).Displayed;
        }
        public bool exists_btn_Portfolio()
        {
            return _driver.FindElement(btn_Portfolio).Displayed;
        }
        
       
       

    }
}