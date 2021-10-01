from selenium import webdriver
import time
import unittest
import softest
from selenium.common.exceptions import TimeoutException
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common import by
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Pages.EbayHome import EbayHome
from Pages.EbaySearchResults import EbaySearchResults

class Ebay(unittest.TestCase):

    @classmethod
    def setUp(self):
        self.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
        self.driver.maximize_window()
        self.driver.get("https://www.ebay.com/")


    def test_EbayWebsitePrintAllResults(self):
        wait = WebDriverWait(self.driver, 10)
        ebayHome = EbayHome(self.driver)
        ebaySearchResults = EbaySearchResults(self.driver)

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.searchField)))
        self.assertTrue(self, ebayHome.displaysearchField())
        ebayHome.searchInput("Apple Watches")

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_AllCategories)))
        self.assertTrue(self, ebayHome.displaybtn_AllCategories())
        ebayHome.clickbtn_AllCategories()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.category_ConsumerElectronics)))
        self.assertTrue(self, ebayHome.displaycategory_ConsumerElectronics())
        ebayHome.clickcategory_ConsumerElectronics()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_Search)))
        self.assertTrue(self, ebayHome.displaybtn_Search())
        ebayHome.clickbtn_Search()

        wait.until(EC.presence_of_element_located((By.XPATH, ebaySearchResults.searchCount)))
        self.assertTrue(self, ebaySearchResults.displaysearchCount())

        for i in range(200):
            resultCount = ebaySearchResults.list_of_elements()
            resultCount1 = len(resultCount)
            print(resultCount1)
            time.sleep(2)
            html = self.driver.find_element_by_tag_name('html')
            html.send_keys(Keys.END)
            for value in resultCount:
                print(value.text)
            wait.until(EC.presence_of_element_located((By.XPATH, ebaySearchResults.btn_NextPage)))

            #self.soft_assert(self.assertTrue(self, ebaySearchResults.displaybtn_NextPage()))
            try:
                wait.until(EC.presence_of_element_located((By.XPATH, ebaySearchResults.btn_NextPage_disabled)))
                print("Disabled button found")
                break
            except TimeoutException:
                print("Disabled button not found")
                ebaySearchResults.clickbtn_NextPage()

    def test_PrintNthResult(self):
        wait = WebDriverWait(self.driver, 10)
        ebayHome = EbayHome(self.driver)
        ebaySearchResults = EbaySearchResults(self.driver)
        value=5

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.searchField)))
        self.assertTrue(self, ebayHome.displaysearchField())
        ebayHome.searchInput("Apple Watches")

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_AllCategories)))
        self.assertTrue(self, ebayHome.displaybtn_AllCategories())
        ebayHome.clickbtn_AllCategories()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.category_ConsumerElectronics)))
        self.assertTrue(self, ebayHome.displaycategory_ConsumerElectronics())
        ebayHome.clickcategory_ConsumerElectronics()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_Search)))
        self.assertTrue(self, ebayHome.displaybtn_Search())
        ebayHome.clickbtn_Search()

        elements = ebaySearchResults.list_of_elements()
        length = len(elements)
        print(length)

        if value<=length:
            print(elements[value-1].text)

    def test_printItemsPerPage(self):
        wait = WebDriverWait(self.driver, 10)
        ebayHome = EbayHome(self.driver)
        ebaySearchResults = EbaySearchResults(self.driver)

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.searchField)))
        self.assertTrue(self, ebayHome.displaysearchField())
        ebayHome.searchInput("Apple Watches")

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_AllCategories)))
        self.assertTrue(self, ebayHome.displaybtn_AllCategories())
        ebayHome.clickbtn_AllCategories()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.category_ConsumerElectronics)))
        self.assertTrue(self, ebayHome.displaycategory_ConsumerElectronics())
        ebayHome.clickcategory_ConsumerElectronics()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_Search)))
        self.assertTrue(self, ebayHome.displaybtn_Search())
        ebayHome.clickbtn_Search()

        html = self.driver.find_element_by_tag_name('html')
        html.send_keys(Keys.END)

        wait.until(EC.presence_of_element_located((By.XPATH, ebaySearchResults.itemsPerPage)))
        self.assertTrue(self, ebaySearchResults.displayitemsPerPage())

        result = ebaySearchResults.list_of_elements()
        items = ebaySearchResults.get_itemsPerPage().text
        itemsint = int(items)
        print(items)

        for value in range(itemsint):
            print((result[value].text))

#######################End of testcase##################

    def test_PrintResultWhileScrolling(self):
        wait = WebDriverWait(self.driver, 10)
        ebayHome = EbayHome(self.driver)
        ebaySearchResults = EbaySearchResults(self.driver)

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.searchField)))
        self.assertTrue(self, ebayHome.displaysearchField())
        ebayHome.searchInput("Apple Watches")

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_AllCategories)))
        self.assertTrue(self, ebayHome.displaybtn_AllCategories())
        ebayHome.clickbtn_AllCategories()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.category_ConsumerElectronics)))
        self.assertTrue(self, ebayHome.displaycategory_ConsumerElectronics())
        ebayHome.clickcategory_ConsumerElectronics()

        wait.until(EC.presence_of_element_located((By.XPATH, ebayHome.btn_Search)))
        self.assertTrue(self, ebayHome.displaybtn_Search())
        ebayHome.clickbtn_Search()

        result = ebaySearchResults.list_of_elements()
        length = len(result)

        for value in range(length):
            Element = result[value]
            self.driver.execute_script("arguments[0].scrollIntoView();", Element)
            print(value)
            print(result[value].text)

###############################End of testcase######################

    @classmethod
    def tearDown(self):
        self.driver.quit()

if __name__=='__main__':
    unittest.main()

