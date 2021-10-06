from selenium import webdriver
import time
import unittest
import HtmlTestRunner
#
class config(unittest.TestCase):

    def setUp(self):
        self.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
        self.driver.maximize_window()


    def tearDown(self):
        self.driver.quit()


if __name__=='__main__':
    unittest.main(testRunner=HtmlTestRunner.HTMLTestRunner(output='Reports'))
