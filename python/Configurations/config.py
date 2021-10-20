from selenium import webdriver
import time
import unittest
import HtmlTestRunner
from HtmlTestRunner import HTMLTestRunner
from HtmlTestRunner import result
from unittest import TestResult, TextTestResult
import sys
sys.path.append("C:/Users/Duraze/PycharmProjects/pythonProject")

from unittest import TestLoader, TestSuite

#import tintash
#import webAutomation
#import tintash
#import Ebay


class config1(unittest.TestCase, result.HtmlTestResult):
    images=None
    # def setUpClass(cls):
    #     cls.test_runner = HtmlTestRunner.HTMLTestRunner(output="Reports")
    #     print(cls.test_runner)


    def setUp(self):
        self.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
        self.driver.maximize_window()



    def tearDown(self):

        for classmethod, error in self._outcome.errors:
            if error:
                self.driver.get_screenshot_as_file('../ScreenShots/'+self.id()+".png")


        self.driver.close()


    def stopTest(self, test):
        TextTestResult.stopTest(self, test)
        self.stop_time = time.time()
        if self.callback and callable(self.callback):
            self.callback()
            self.callback = None
    def addSuccess(self, test):
        self._prepare_callback(self.infoclass(self, test), self.successes, "OK", ".")
        print("Overrided function has been called")


if __name__=='__main__':
    unittest.main()
