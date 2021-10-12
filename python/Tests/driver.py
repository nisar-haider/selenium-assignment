import self
from selenium import webdriver
import time
import unittest
import HtmlTestRunner
from HtmlTestRunner import HTMLTestRunner
from unittest import TestLoader, TestSuite
import softest
from selenium.common.exceptions import TimeoutException
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common import by
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
#import Ebay
import tintash
#from tintash import Tintash1
#from Ebay import Ebay
import webAutomation
from webAutomation import dragDrop
from config import config1

class driver1(config1):

    def callID(self):
        return (self.id())

    def run_all_suites(self):
        # Create test suite.
        test_suite = unittest.TestSuite()
        # Load all test case class in current folder.
        all_test_cases = unittest.defaultTestLoader.discover('.', '*.py')
        # Loop the found test cases and add them into test suite.
        for test_case in all_test_cases:
            test_suite.addTests(test_case)

            # Create HtmlTestRunner object and run the test suite.
        test_runner = HtmlTestRunner.HTMLTestRunner(output='Reports', combine_reports=True)
        test_runner.run(test_suite)






if __name__=='__main__':
    # conf = config()
    # example_tests = TestLoader().loadTestsFromTestCase(Tintash)
    # example2_tests = TestLoader().loadTestsFromTestCase(dragDrop)
    #
    # suite = TestSuite([example_tests, example2_tests])
    #
    # runner = HTMLTestRunner(output='C:\\Users\Duraze\\PycharmProjects\\pythonProject\\Reports', combine_reports=True, report_name="MyReport", report_title="Test Suites Report")

    # smoke_test.addTests([
    #     unittest.defaultTestLoader.loadTestsFromTestCase(d.callID()),
    #     #unittest.defaultTestLoader.loadTestsFromTestCase(webAutomation.dragDrop),
    # ])

    driver1.run_all_suites(self=driver1)








