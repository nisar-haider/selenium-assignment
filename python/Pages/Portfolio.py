class Portfolio:
    def __init__(self, driver):
        self.driver = driver

    txt_Portfolio = "//h1[text()='Portfolio']"
    dd_Solution = "//*[text()='Select Solution']"
    chkbox_ddL_Solution = "//*[text()='Web Development']/preceding-sibling::input"
    dd_Technology = "//*[text()='Select Technology']"
    chkbox_ddL_Technology = "//*[text()='ReactJS']/preceding-sibling::input"
    dd_Industry = "//*[text()='Select Industry']"
    chkbox_ddL_Industry = "//*[text()='Workplace Experience & Management']/preceding-sibling::input"
    txt_Camaradly = "//*[contains(text(),'Camaradly is an employee-first')]"
    logo_Camaradly = "//article[@class='ProjectCard-module--card--13fUh']/header/div[2]/img[@alt='camaradly']"
    text = "Camaradly is an employee-first"

    def displayTxtPortfolio(self):
        return self.driver.find_element_by_xpath(self.txt_Portfolio).is_displayed()

    def displaydd_Solution(self):
        return self.driver.find_element_by_xpath(self.dd_Solution).is_displayed()

    def clickchkbox_ddL_Solution(self):
        self.driver.find_element_by_xpath(self.chkbox_ddL_Solution).click()

    def displaydd_Technology(self):
        return self.driver.find_element_by_xpath(self.dd_Technology).is_displayed()

    def clickchkbox_ddL_Technology(self):
        self.driver.find_element_by_xpath(self.chkbox_ddL_Technology).click()

    def displaydd_Industry(self):
        return self.driver.find_element_by_xpath(self.dd_Technology).is_displayed()

    def clickchkbox_ddL_Industry(self):
        self.driver.find_element_by_xpath(self.chkbox_ddL_Industry).click()

    def clickdd_Solution(self):
        self.driver.find_element_by_xpath(self.dd_Solution).click()

    def clickdd_Technology(self):
        self.driver.find_element_by_xpath(self.dd_Technology).click()

    def clickdd_Industry(self):
        self.driver.find_element_by_xpath(self.dd_Industry).click()

    def displayCamardly(self):
        return self.driver.find_element_by_xpath(self.txt_Camaradly).is_displayed()
