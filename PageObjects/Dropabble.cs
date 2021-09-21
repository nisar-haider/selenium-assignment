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
    class Dropabble
    {
        private IWebDriver _driver;

        public Dropabble(IWebDriver driver)
        {
            _driver = driver;
        }


        public By From=By.XPath("//*[text()='Drag me to my target']");
        public By To=By.XPath("//*[text()='Drop here']");
        public By txt_Dropped=By.XPath("//*[text()='Dropped!']");
       


        //Fuctions to test if elements are being displayed 
        public bool exists_From()
        {
            return _driver.FindElement(From).Displayed;
        }
        public bool exists_To()
        {
            return _driver.FindElement(To).Displayed;
        }
        public bool exists_txt_Dropped()
        {
            return _driver.FindElement(txt_Dropped).Displayed;
        }
        
       

    }
}