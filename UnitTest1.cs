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
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [OneTimeTearDown]
        public void close()
        {
            //driver.Close();
        }
    }
}