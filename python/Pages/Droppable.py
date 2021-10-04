class Droppable:

    def __init__(self, driver):
        self.driver=driver

    source = "//*[text()='Drag me to my target']"
    target = "//*[text()='Drop here']"
    txt_Dropped = "//*[text()='Dropped!']"

    def displaySource(self):
        return self.driver.find_element_by_xpath(self.source).is_displayed()

    def displayTarget(self):
        return self.driver.find_element_by_xpath(self.target).is_displayed()

    def displayTxtDropped(self):
        return self.driver.find_element_by_xpath(self.txt_Dropped).is_displayed()
