from HTMLrenderer import render
from selenium import webdriver
import time
import unittest
import HtmlTestRunner
from HtmlTestRunner import HTMLTestRunner
from HtmlTestRunner import result
import requests
from unittest import TestResult, TextTestResult
import sys
sys.path.append("/")
import os
dirname = os.path.dirname(__file__)



class config1(unittest.TestCase, result.HtmlTestResult):
    template_args=None
    image=None
    current_working_dir = os.getcwd()


    def setUp(self):
        self.driver = webdriver.Chrome("../chromedriver.exe")
        self.driver.maximize_window()


    def capture_screenShot(self):
        print(self.current_working_dir)
        self.driver.get_screenshot_as_file('../ScreenShots/' + self.id() + ".png")

    def tearDown(self):

        for classmethod, error in self._outcome.errors:
            if error:
                self.capture_screenShot()


        self.driver.close()



    def stopTest(self, test):
        self.images = os.path.abspath(self.id()+".png").replace("Tests","ScreenShots")
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
