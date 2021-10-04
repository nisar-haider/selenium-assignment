from selenium import webdriver
import time
import unittest
import HtmlTestRunner
from selenium.common.exceptions import TimeoutException
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common import by
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Pages.Droppable import Droppable


class dragDrop(unittest.TestCase):



    @classmethod
    def setUp(self):
        self.driver = webdriver.Chrome("C:/Users/Duraze/PycharmProjects/pythonProject/chromedriver.exe")
        self.driver.maximize_window()
        self.driver.get("https://jqueryui.com/droppable/")


    def test_dragDropTest(self):
        wait = WebDriverWait(self.driver, 60)
        droppable = Droppable(self.driver)
        self.driver.switch_to.frame(0)
        source2=wait.until(EC.presence_of_element_located((By.XPATH, droppable.source)))
        self.assertTrue(self, droppable.displaySource())
        target2=wait.until(EC.presence_of_element_located((By.XPATH, droppable.target)))
        self.assertTrue(self, droppable.displayTarget())

        actions = ActionChains(self.driver)
        actions.drag_and_drop(source2, target2).perform()

        wait.until(EC.presence_of_element_located((By.XPATH, droppable.txt_Dropped)))
        self.assertTrue(self, droppable.displayTxtDropped())
        time.sleep(5)



    @classmethod
    def tearDown(self):
        self.driver.quit()

if __name__=='__main__':
    unittest.main(testRunner=HtmlTestRunner.HTMLTestRunner(output='C:\\Users\Duraze\\PycharmProjects\\pythonProject\\Reports', combine_reports=True))


