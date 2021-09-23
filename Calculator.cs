using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
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
    public class Calculator:config.ConfigCalculator
    {
        private WindowsDriver<WindowsElement> CalculatorSession = null;

        void CreateWinAppSession()
        {
            var desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        }

        void waitFortheElementToDisplayed(WindowsDriver<WindowsElement> Session,string name){
            bool value=false;
            for(int i=0 ;i<90 ;i++)
            {
                try{
                    value=Session.FindElementByName(name).Displayed;
                }
                catch(Exception) 
                {
                    value=false;
                }
                if(value){
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        [Test]
        public void calculatorAddition()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"One");
            CalculatorSession.FindElementByName("One").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Plus");
            CalculatorSession.FindElementByName("Plus").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Five");
            CalculatorSession.FindElementByName("Five").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

            Assert.AreEqual(result,"Display is 6");

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }

        [Test]
        public void calculatorSubtraction()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"Five");
            CalculatorSession.FindElementByName("Five").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Minus");
            CalculatorSession.FindElementByName("Minus").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Two");
            CalculatorSession.FindElementByName("Two").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

            Assert.AreEqual(result,"Display is 3");

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }

        [Test]
        public void calculatorDivision()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"Nine");
            CalculatorSession.FindElementByName("Nine").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Divide by");
            CalculatorSession.FindElementByName("Divide by").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

            Assert.AreEqual(result,"Display is 3"); 

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }
        
        [Test]
        public void calculatorMultiplication()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Multiply by");
            CalculatorSession.FindElementByName("Multiply by").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

            Assert.AreEqual(result,"Display is 9"); 

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }
    
        [Test]
        public void calculatorSquare()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Square");
            CalculatorSession.FindElementByName("Square").Click();
            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

            Assert.AreEqual(result,"Display is 9"); 

            waitFortheElementToDisplayed(CalculatorSession,"Five");
            CalculatorSession.FindElementByName("Five").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Square");
            CalculatorSession.FindElementByName("Square").Click();
            result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;
        

            Assert.AreEqual(result,"Display is 25"); 

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }
    
        [Test]
        public void calculatorClearScreen()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Multiply by");
            CalculatorSession.FindElementByName("Multiply by").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Clear");
            CalculatorSession.FindElementByName("Clear").Click();

            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

            Assert.AreEqual(result,"Display is 0"); 

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }


        [Test]
        public void calculatorOpenScientificMode()
        {
            CreateWinAppSession();

            waitFortheElementToDisplayed(CalculatorSession,"Open Navigation");
            CalculatorSession.FindElementByName("Open Navigation").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Scientific Calculator");
            CalculatorSession.FindElementByName("Scientific Calculator").Click();

            bool displayed = CalculatorSession.FindElementByName("Scientific Calculator mode").Displayed;

            Assert.IsTrue(displayed); 

            //Check Modulo function
            waitFortheElementToDisplayed(CalculatorSession,"Nine");
            CalculatorSession.FindElementByName("Nine").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Modulo");
            CalculatorSession.FindElementByName("Modulo").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;
        

            Assert.AreEqual(result,"Display is 0"); 

            waitFortheElementToDisplayed(CalculatorSession,"Clear entry");
            CalculatorSession.FindElementByName("Clear entry").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Seven");
            CalculatorSession.FindElementByName("Seven").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Modulo");
            CalculatorSession.FindElementByName("Modulo").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Three");
            CalculatorSession.FindElementByName("Three").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;
        

            Assert.AreEqual(result,"Display is 1");

            waitFortheElementToDisplayed(CalculatorSession,"Clear entry");
            CalculatorSession.FindElementByName("Clear entry").Click();

            //Check exponential function
            waitFortheElementToDisplayed(CalculatorSession,"Five");
            CalculatorSession.FindElementByName("Five").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Exponential");
            CalculatorSession.FindElementByName("Exponential").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Two");
            CalculatorSession.FindElementByName("Two").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;
        

            Assert.AreEqual(result,"Display is 2");

            waitFortheElementToDisplayed(CalculatorSession,"Clear entry");
            CalculatorSession.FindElementByName("Clear entry").Click();
            //Calculating Sin function
            waitFortheElementToDisplayed(CalculatorSession,"Nine");
            CalculatorSession.FindElementByName("Nine").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Zero");
            CalculatorSession.FindElementByName("Zero").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Trigonometry");
            CalculatorSession.FindElementByName("Trigonometry").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Sine");
            CalculatorSession.FindElementByName("Sine").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Equals");
            CalculatorSession.FindElementByName("Equals").Click();

            result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;
        

            Assert.AreEqual(result,"Display is 1");

            waitFortheElementToDisplayed(CalculatorSession,"Clear entry");
            CalculatorSession.FindElementByName("Clear entry").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Open Navigation");
            CalculatorSession.FindElementByName("Open Navigation").Click();

            waitFortheElementToDisplayed(CalculatorSession,"Standard Calculator");
            CalculatorSession.FindElementByName("Standard Calculator").Click();

            bool displayed1 = CalculatorSession.FindElementByName("Standard Calculator mode").Displayed;

            Assert.IsTrue(displayed);

            waitFortheElementToDisplayed(CalculatorSession,"Close Calculator");
            CalculatorSession.FindElementByName("Close Calculator").Click();

        }


    }       
}
