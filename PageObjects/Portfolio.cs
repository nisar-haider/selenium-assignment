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
    class Portfolio
    {
        private IWebDriver _driver;

        public Portfolio(IWebDriver driver)
        {
            _driver = driver;
        }


        public By txt_Portfolio=By.XPath("//h1[text()='Portfolio']");
        public By dd_Solution=By.XPath("//*[text()='Select Solution']");
        public By chkbox_ddL_Solution=By.XPath("//*[text()='Web Development']/preceding-sibling::input");
        public By dd_Technology=By.XPath("//*[text()='Select Technology']");
        public By chkbox_ddL_Technology=By.XPath("//*[text()='ReactJS']/preceding-sibling::input");
        public By dd_Industry=By.XPath("//*[text()='Select Industry']");
        public By chkbox_ddL_Industry=By.XPath("//*[text()='Workplace Experience & Management']/preceding-sibling::input");
        public By txt_Camaradly=By.XPath("//*[contains(text(),'Camaradly is an employee-first')]");


        //Fuctions to test if elements are being displayed 
       
        public bool exists_txt_Portfolio()
        {
            return _driver.FindElement(txt_Portfolio).Displayed;
        }
        public bool exists_dd_Solution()
        {
            return _driver.FindElement(dd_Solution).Displayed;
        }
        public bool exists_chkbox_ddL_Solution()
        {
            return _driver.FindElement(chkbox_ddL_Solution).Displayed;
        }
        public bool isSelected_chkbox_ddL_Solution()
        {
            return _driver.FindElement(chkbox_ddL_Solution).Selected;
        }
        public bool exists_dd_Technology()
        {
            return _driver.FindElement(dd_Technology).Displayed;
        }
        public bool exists_chkbox_ddL_Technology()
        {
            return _driver.FindElement(chkbox_ddL_Technology).Displayed;
        }
        public bool isSelected_chkbox_ddL_Technology()
        {
            return _driver.FindElement(chkbox_ddL_Technology).Selected;
        }
        
        public bool exists_dd_Industry()
        {
            return _driver.FindElement(dd_Industry).Displayed;
        }
        public bool exists_chkbox_ddL_Industry()
        {
            return _driver.FindElement(chkbox_ddL_Industry).Displayed;
        }
        public bool isSelected_chkbox_ddL_Industry()
        {
            return _driver.FindElement(chkbox_ddL_Industry).Selected;
        }
        public bool exists_txt_Camaradly()
        {
            return _driver.FindElement(txt_Camaradly).Displayed;
        }

       

    }
}