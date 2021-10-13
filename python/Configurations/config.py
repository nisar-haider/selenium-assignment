from selenium import webdriver
import time
import unittest
import HtmlTestRunner
from HtmlTestRunner import HTMLTestRunner

from unittest import TestLoader, TestSuite

#import tintash
#import webAutomation
#import tintash
#import Ebay


class config1(unittest.TestCase):
    testname = ""
    test_runner = ""
    test_suite = ""

    # def setUpClass(cls):
    #     cls.test_runner = HtmlTestRunner.HTMLTestRunner(output="Reports")
    #     print(cls.test_runner)


    def setUp(self):
        self.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
        self.driver.maximize_window()


    def tearDown(self):
        for classmethod, error in self._outcome.errors:
            if error:
                self.driver.get_screenshot_as_file("screenshot" + self.id() + ".png")

        self.driver.close()





if __name__=='__main__':
    unittest.main()
