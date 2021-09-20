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
    public class Calculator
    {
        private WindowsDriver<WindowsElement> CalculatorSession = null;
        IWebDriver driver;

    [Test]
      public void calculatorAddition()
      {
        var desiredCapabilities = new AppiumOptions();
        desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        CalculatorSession.FindElementByName("One").Click();
        CalculatorSession.FindElementByName("Plus").Click();
        CalculatorSession.FindElementByName("Five").Click();
        CalculatorSession.FindElementByName("Equals").Click();

        String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

        Assert.AreEqual(result,"Display is 6");

        CalculatorSession.FindElementByName("Close Calculator").Click();

      }

      [Test]
      public void calculatorSubtraction()
      {
        var desiredCapabilities = new AppiumOptions();
        desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        CalculatorSession.FindElementByName("Five").Click();
        CalculatorSession.FindElementByName("Minus").Click();
        CalculatorSession.FindElementByName("Two").Click();
        CalculatorSession.FindElementByName("Equals").Click();

        String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

        Assert.AreEqual(result,"Display is 3");

        CalculatorSession.FindElementByName("Close Calculator").Click();

      }

      [Test]
      public void calculatorDivision()
      {
        var desiredCapabilities = new AppiumOptions();
        desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        CalculatorSession.FindElementByName("Nine").Click();
        CalculatorSession.FindElementByName("Divide by").Click();
        CalculatorSession.FindElementByName("Three").Click();
        CalculatorSession.FindElementByName("Equals").Click();

        String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

        Assert.AreEqual(result,"Display is 3"); 

        CalculatorSession.FindElementByName("Close Calculator").Click();

      }
        
        [Test]
      public void calculatorMultiplication()
      {
        var desiredCapabilities = new AppiumOptions();
        desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        CalculatorSession.FindElementByName("Three").Click();
        CalculatorSession.FindElementByName("Multiply by").Click();
        CalculatorSession.FindElementByName("Three").Click();
        CalculatorSession.FindElementByName("Equals").Click();

        String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

        Assert.AreEqual(result,"Display is 9"); 

        CalculatorSession.FindElementByName("Close Calculator").Click();

      }
        [Test]
      public void calculatorSquare()
      {
        var desiredCapabilities = new AppiumOptions();
        desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        CalculatorSession.FindElementByName("Three").Click();
        CalculatorSession.FindElementByName("Square").Click();
        String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

        Assert.AreEqual(result,"Display is 9"); 

        CalculatorSession.FindElementByName("Five").Click();
        CalculatorSession.FindElementByName("Square").Click();
        result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;
        

        Assert.AreEqual(result,"Display is 25"); 

        CalculatorSession.FindElementByName("Close Calculator").Click();

      }
         [Test]
      public void calculatorClearScreen()
      {
        var desiredCapabilities = new AppiumOptions();
        desiredCapabilities.AddAdditionalCapability("app","Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        CalculatorSession =  new WindowsDriver <WindowsElement> (new Uri("http://127.0.0.1:4723"), desiredCapabilities);

        CalculatorSession.FindElementByName("Three").Click();
        CalculatorSession.FindElementByName("Multiply by").Click();
        CalculatorSession.FindElementByName("Three").Click();
        CalculatorSession.FindElementByName("Equals").Click();

        CalculatorSession.FindElementByName("Clear").Click();

        String result = CalculatorSession.FindElementByAccessibilityId("CalculatorResults").Text;

        Assert.AreEqual(result,"Display is 0"); 

        CalculatorSession.FindElementByName("Close Calculator").Click();

      }




            
        
        
        
        public void Setup()
        {
        }

        [Test]
        public void AutomateCalculator()
        {
            
 
        }
    }
}
