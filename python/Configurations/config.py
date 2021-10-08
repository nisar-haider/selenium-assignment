from selenium import webdriver
import time
import unittest
import HtmlTestRunner
from HtmlTestRunner import HTMLTestRunner

from unittest import TestLoader, TestSuite

#import tintash
#import webAutomation
#import tintash


class config1(unittest.TestCase):


    def setUp(self):
        self.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
        self.driver.maximize_window()
        print(self.id())
        smoke = self.id()
        smoke1 = type(self).__name__
        print(smoke)
        smoke_test=unittest.TestSuite
        smoke_test.addTests([unittest.defaultTestLoader.loadTestsFromTestCase(smoke1)])
        #smoke_test.a
        runner = HTMLTestRunner(output='C:\\Users\Duraze\\PycharmProjects\\pythonProject\\Reports',
                                combine_reports=True, report_name="MyReport", report_title="Test Suites Report")
        runner.run(smoke1)





    def tearDown(self):
        self.driver.close()



if __name__=='__main__':
    unittest.main()
