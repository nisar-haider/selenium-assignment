from _ast import Assert

import self as self
from selenium import webdriver
import time
import unittest
from selenium.common.exceptions import TimeoutException
from selenium.webdriver.common import by
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Pages.TTHomePage import TTHomePage
from Pages.Google import GooglePage
from Pages.Portfolio import Portfolio

class Tintash(unittest.TestCase):

    @classmethod
    def setUp(self):
        self.driver = webdriver.Chrome()
        self.driver.maximize_window()
        self.driver.get("https://www.google.com/")

    @classmethod
    def test_TintashWebsite(self):
        wait = WebDriverWait(self.driver, 60)
        googlepage = GooglePage(self.driver)
        ttHome = TTHomePage(self.driver)
        portfolio = Portfolio(self.driver)
        googlepage.searchInput("Tintash")
        try:
            wait.until(EC.presence_of_element_located((By.XPATH, googlepage.btn_search)))
            print ("Element is ready")
            googlepage.clickSearchButton()
        except TimeoutException:
            print ("Element is not loaded")


        wait.until(EC.element_to_be_clickable((By.XPATH, googlepage.tintashLink)))
        googlepage.clickTintashLink()

        wait.until(EC.presence_of_element_located((By.XPATH, ttHome.btn_Portfolio)))
        ttHome.clickPortfolio()

        time.sleep(2)

        Element = self.driver.find_element_by_xpath("//span[text()='View Casestudy']")
        self.driver.execute_script("arguments[0].scrollIntoView();", Element)

        #portfolio.displaydd_Solution()
        wait.until(EC.presence_of_element_located((By.XPATH, portfolio.dd_Solution)))
        portfolio.clickdd_Solution()
        portfolio.clickchkbox_ddL_Solution()

        #portfolio.displaydd_Technology()
        wait.until(EC.presence_of_element_located((By.XPATH, portfolio.dd_Technology)))
        portfolio.clickdd_Technology()
        portfolio.clickchkbox_ddL_Technology()

        #portfolio.displaydd_Industry()
        wait.until(EC.presence_of_element_located((By.XPATH, portfolio.dd_Industry)))
        portfolio.clickdd_Industry()

        Element1 = self.driver.find_element_by_xpath("//*[text()='Retail & eCommerce']")
        self.driver.execute_script("arguments[0].scrollIntoView();", Element1)
        portfolio.clickchkbox_ddL_Industry()

        time.sleep(5)
        Element2 = self.driver.find_element_by_xpath("//*[contains(text(),'Camaradly is an employee-first')]")
        self.driver.execute_script("arguments[0].scrollIntoView();", Element2)

        time.sleep(5)

        wait.until(EC._element_if_visible((By.XPATH, portfolio.txt_Camaradly)))
        #elem = self.driver.find_element_by_xpath(portfolio.txt_Camaradly)
        #self.assertTrue(elem).is_displayed()
        print("Camaradly exists!")


    time.sleep(5)
    def tearDown(self):
        self.driver.quit()