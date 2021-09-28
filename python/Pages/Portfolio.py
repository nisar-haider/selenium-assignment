class Portfolio:
    def __init__(self, driver):
        self.driver = driver

        self.txt_Portfolio = "//h1[text()='Portfolio']"
        self.dd_Solution = "//*[text()='Select Solution']"
        self.chkbox_ddL_Solution = "//*[text()='Web Development']/preceding-sibling::input"
        self.dd_Technology = "//*[text()='Select Technology']"
        self.chkbox_ddL_Technology = "//*[text()='ReactJS']/preceding-sibling::input"
        self.dd_Industry = "//*[text()='Select Industry']"
        self.chkbox_ddL_Industry = "//*[text()='Workplace Experience & Management']/preceding-sibling::input"
        self.txt_Camaradly = "//*[contains(text(),'Camaradly is an employee-first')]"

    def displayTxtPortfolio(self):
        self.driver.find_element_by_xpath(self.txt_Portfolio).display()

    def displaydd_Solution(self):
        self.driver.find_element_by_xpath(self.dd_Solution).display()

    def clickchkbox_ddL_Solution(self):
        self.driver.find_element_by_xpath(self.chkbox_ddL_Solution).click()

    def displaydd_Technology(self):
        self.driver.find_element_by_xpath(self.dd_Technology).display()

    def clickchkbox_ddL_Technology(self):
        self.driver.find_element_by_xpath(self.chkbox_ddL_Technology).click()

    def displaydd_Industry(self):
        self.driver.find_element_by_xpath(self.dd_Technology).display()

    def clickchkbox_ddL_Industry(self):
        self.driver.find_element_by_xpath(self.chkbox_ddL_Industry).click()

    def clickdd_Solution(self):
        self.driver.find_element_by_xpath(self.dd_Solution).click()

    def clickdd_Technology(self):
        self.driver.find_element_by_xpath(self.dd_Technology).click()

    def clickdd_Industry(self):
        self.driver.find_element_by_xpath(self.dd_Industry).click()

