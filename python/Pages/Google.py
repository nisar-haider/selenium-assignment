from selenium import webdriver

class GooglePage:

    def __init__(self, driver):
        self.driver=driver

    searchField = "//*[@title='Search']"
    list_searchResult = "//ul[@role ='listbox']//li"
    tintashLink = "//*[text()='Tintash - Stanford Alumni Led Web & App Development ...']"
    btn_search = "//*[@class='FPdoLc lJ9FBc']/child::center/input[@name='btnK']"

    def searchInput(self, input):
        self.driver.find_element_by_xpath(self.searchField).send_keys(input)

    def clickSearchButton(self):
        self.driver.find_element_by_xpath(self.btn_search).click()

    def clickTintashLink(self):
        self.driver.find_element_by_xpath(self.tintashLink).click()








