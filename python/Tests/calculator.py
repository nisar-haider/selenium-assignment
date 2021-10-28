import unittest
from appium import webdriver
from selenium.common.exceptions import TimeoutException
import time
import HtmlTestRunner
import sys
sys.path.append("C:/Users/Duraze/PycharmProjects/pythonProject")



class Calculator(unittest.TestCase):

    calcsession = None
    def setUp(self):
        try:

            desired_caps = {}
            desired_caps["app"] = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App"
            desired_caps["ms:waitForAppLauch"] = 50
            self.calcsession = webdriver.Remote(
                command_executor='http://127.0.0.1:4723',
                desired_capabilities=desired_caps)
        except:
            desired_caps = {}
            desired_caps["app"] = "Root"
            self.calcsession = webdriver.Remote(
                command_executor='http://127.0.0.1:4723',
                desired_capabilities=desired_caps)

    def waitFortheElementToDisplayed(self, driver, name):
        value = False
        for i in range(90):
            try:
                value=self.calcsession.find_element_by_name("One").is_displayed()

            except TimeoutException:
                value = False

            if value:
                break
            else:
                time.sleep(1)



    def test_addition(self):
        #self.createWinAppSession()
        num1=None
        num2=None
        self.waitFortheElementToDisplayed(self.calcsession, "One")
        self.calcsession.find_element_by_name("One").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Plus")
        self.calcsession.find_element_by_name("Plus").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Five")
        self.calcsession.find_element_by_name("Five").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        print(result)

        self.assertEqual(result,"Display is 6")

    def test_subtraction(self):
        self.waitFortheElementToDisplayed(self.calcsession, "Five")
        self.calcsession.find_element_by_name("Five").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Minus")
        self.calcsession.find_element_by_name("Minus").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Two")
        self.calcsession.find_element_by_name("Two").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        print(result)

        self.assertEqual(result, "Display is 3")

    def test_division(self):
        self.waitFortheElementToDisplayed(self.calcsession, "Nine")
        self.calcsession.find_element_by_name("Nine").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Divide by")
        self.calcsession.find_element_by_name("Divide by").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        print(result)

        self.assertEqual(result, "Display is 3")

    def test_multiply(self):
        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Multiply by")
        self.calcsession.find_element_by_name("Multiply by").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        print(result)

        self.assertEqual(result, "Display is 9")

    def test_Square(self):
        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Square")
        self.calcsession.find_element_by_name("Square").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        self.assertEqual(result, "Display is 9")

        self.waitFortheElementToDisplayed(self.calcsession, "Five")
        self.calcsession.find_element_by_name("Five").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Square")
        self.calcsession.find_element_by_name("Square").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        self.assertEqual(result, "Display is 25")

    def test_calculatorClearScreen(self):
        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Multiply by")
        self.calcsession.find_element_by_name("Multiply by").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Clear entry")
        self.calcsession.find_element_by_name("Clear entry").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        print(result)

        self.assertEqual(result, "Display is 0")

    def test_calculatorScientificMode(self):
        self.waitFortheElementToDisplayed(self.calcsession, "Open Navigation")
        self.calcsession.find_element_by_name("Open Navigation").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Scientific Calculator")
        self.calcsession.find_element_by_name("Scientific Calculator").click()

        # display = self.calcsession.find_element_by_accessibility_id("Scientific Calculator mode").is_displayed()
        # self.assertTrue(display)

        self.waitFortheElementToDisplayed(self.calcsession, "Seven")
        self.calcsession.find_element_by_name("Seven").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Modulo")
        self.calcsession.find_element_by_name("Modulo").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Three")
        self.calcsession.find_element_by_name("Three").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        self.assertEqual(result, "Display is 1")

        self.waitFortheElementToDisplayed(self.calcsession, "Clear entry")
        self.calcsession.find_element_by_name("Clear entry").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Five")
        self.calcsession.find_element_by_name("Five").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Exponential")
        self.calcsession.find_element_by_name("Exponential").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Two")
        self.calcsession.find_element_by_name("Two").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        self.assertEqual(result, "Display is 2")

        self.waitFortheElementToDisplayed(self.calcsession, "Clear entry")
        self.calcsession.find_element_by_name("Clear entry").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Nine")
        self.calcsession.find_element_by_name("Nine").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Zero")
        self.calcsession.find_element_by_name("Zero").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Trigonometry")
        self.calcsession.find_element_by_name("Trigonometry").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Sine")
        self.calcsession.find_element_by_name("Sine").click()

        self.waitFortheElementToDisplayed(self.calcsession, "Equals")
        self.calcsession.find_element_by_name("Equals").click()

        result = self.calcsession.find_element_by_accessibility_id("CalculatorResults").text
        self.assertEqual(result, "Display is 1")

        self.waitFortheElementToDisplayed(self.calcsession, "Clear entry")
        self.calcsession.find_element_by_name("Clear entry").click()

    def runtests(self):
        unittest.main(testRunner=HtmlTestRunner.HTMLTestRunner(output='../Reports',report_name="Complete test suites", report_title="Calculator Test Suite", add_timestamp=True))


    def tearDown(self):
        self.calcsession.close()


if __name__ == '__main__':
    Calculator.runtests(self=Calculator)








