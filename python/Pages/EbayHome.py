class EbayHome:

    def __init__(self, driver):
        self.driver=driver

    searchField = "//input[@type='text']"
    btn_AllCategories = "//div[@id='gh-cat-box']/child::select"
    category_ConsumerElectronics = "//div[@id='gh-cat-box']/child::select/child::option[text()='Consumer Electronics']"
    btn_Search = "//input[@class='btn btn-prim gh-spr']"

    def searchInput(self, input):
        self.driver.find_element_by_xpath(self.searchField).send_keys(input)

    def displaysearchField(self):
        return self.driver.find_element_by_xpath(self.searchField).is_displayed()

    def displaybtn_AllCategories(self):
        return self.driver.find_element_by_xpath(self.btn_AllCategories).is_displayed()

    def displaycategory_ConsumerElectronics(self):
        return self.driver.find_element_by_xpath(self.category_ConsumerElectronics).is_displayed()

    def displaybtn_Search(self):
        return self.driver.find_element_by_xpath(self.btn_Search).is_displayed()

    def clickbtn_AllCategories(self):
        self.driver.find_element_by_xpath(self.btn_AllCategories).click()

    def clickcategory_ConsumerElectronics(self):
        self.driver.find_element_by_xpath(self.category_ConsumerElectronics).click()

    def clickbtn_Search(self):
        self.driver.find_element_by_xpath(self.btn_Search).click()
