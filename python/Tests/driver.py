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
from tintash import Tintash
#from Ebay import Ebay
import tintash
import webAutomation
from webAutomation import dragDrop

class driver1(unittest.TestCase):

    def __init__(self, driver):
        self.driver = driver





if __name__=='__main__':
    example_tests = TestLoader().loadTestsFromTestCase(Tintash)
    example2_tests = TestLoader().loadTestsFromTestCase(dragDrop)

    suite = TestSuite([example_tests, example2_tests])

    runner = HTMLTestRunner(output='example_suite')

    unittest.main(testRunner=HtmlTestRunner.HTMLTestRunner(output='C:\\Users\Duraze\\PycharmProjects\\pythonProject\\Reports', combine_reports=True))








