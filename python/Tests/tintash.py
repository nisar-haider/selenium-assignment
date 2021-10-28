import time
import unittest
import HtmlTestRunner
from selenium.common.exceptions import TimeoutException
from selenium.common.exceptions import NoSuchElementException
import sys
sys.path.append("C:/Users/Duraze/PycharmProjects/pythonProject")
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Pages.TTHomePage import TTHomePage
from Pages.Google import GooglePage
from Pages.Portfolio import Portfolio
from Configurations.config import config1



class Tintash1(config1):

    def setUp(self):
        super().setUp()
        self.driver.get("https://www.google.com/")
    #     cls.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
    #     cls.driver.maximize_window()
    #     cls.driver.get("https://www.google.com/")



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
        Element2 = self.driver.find_element_by_xpath("//article[@class='ProjectCard-module--card--13fUh']/header/div[2]/img[@alt='camaradly']")
        self.driver.execute_script("arguments[0].scrollIntoView();", Element2)

        time.sleep(5)

        try:
            wait.until(EC.presence_of_element_located((By.XPATH, portfolio.txt_Camaradly)))
            self.assertTrue(self,portfolio.displayCamardly())
            print("Camaradly exists!")
        except NoSuchElementException:
            print ("Failed!")


    def runtests(self):
        HtmlTestRunner.runner.HtmlTestResult.addSuccess = config1.addSuccess
        unittest.main(testRunner=HtmlTestRunner.HTMLTestRunner(output='../Reports', report_title="Tintash Test Suite", add_timestamp=True, verbosity=2, template='../image.html'))




    def tearDown(self):
        super().tearDown()

if __name__ == '__main__':

    Tintash1.runtests(self=Tintash1)


