class TTHomePage:
    def __init__(self, driver):
        self.driver = driver

    txt_BuildProducts = "//*[text()='Build Products']"
    btn_Portfolio = "//*[text()='Portfolio']"

    def clickPortfolio(self):
        self.driver.find_element_by_xpath(self.btn_Portfolio).click()

