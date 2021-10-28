import time
import unittest
import HtmlTestRunner
import sys
sys.path.append("C:/Users/Duraze/PycharmProjects/pythonProject")
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Pages.Droppable import Droppable
from Configurations.config import config1


class dragDrop(config1):
    def setUp(self):
        super().setUp()
        self.driver.get("https://jqueryui.com/droppable/")


    def test_dragDropTest(self):
        wait = WebDriverWait(self.driver, 10)
        droppable = Droppable(self.driver)
        self.driver.switch_to.frame(0)
        source2=wait.until(EC.presence_of_element_located((By.XPATH, droppable.source)))
        self.assertTrue(self, droppable.displaySource())
        target2=wait.until(EC.presence_of_element_located((By.XPATH, droppable.target)))
        self.assertTrue(self, droppable.displayTarget())

        actions = ActionChains(self.driver)
        actions.drag_and_drop(source2, target2).perform()
        print("Dropped!")
        wait.until(EC.presence_of_element_located((By.XPATH, droppable.txt_Dropped)))
        self.assertTrue(self, droppable.displayTxtDropped())

        time.sleep(5)


    def runtests(self):
        #HtmlTestRunner.runner.HtmlTestResult.addSuccess = config1.addSuccess
        #self.image = os.path.abspath(self.id() + ".png").replace("Tests", "ScreenShots")
        # print(self.image)

        # self.template_args = {
        #     "image": self.id(),
        #
        # }
        print("Web automation")
        print(self.template_args)
        unittest.main(testRunner=HtmlTestRunner.HTMLTestRunner(output='../Reports', report_title="Tintash Test Suite", add_timestamp=True, verbosity=2, template='../image.html',template_args=self.template_args))


    # def tearDown(self):
    #     super.tearDown()

if __name__=='__main__':
    dragDrop.runtests(self=dragDrop)

