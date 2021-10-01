class EbaySearchResults:

    def __init__(self, driver):
        self.driver=driver

    searchCount = "//div[@class='srp-controls__control srp-controls__count']/h1/span"
    searchList = "//div[@class='srp-river-results clearfix']/ul/li"
    resultTitle = "//div[@class='srp-river-results clearfix']/ul/li/div/div[2]/a/h3[@class='s-item__title']"
    itemsPerPage = "//span[@id='srp-ipp-menu']/button/span/span"
    btn_NextPage = "//*[@class='icon icon--pagination-next']/parent::a"
    btn_NextPage_disabled = "//*[@class='icon icon--pagination-next']/parent::a[@aria-disabled='true']"


    def displaysearchList(self):
        return self.driver.find_element_by_xpath(self.searchList).is_displayed()

    def displaysearchCount(self):
        return self.driver.find_element_by_xpath(self.searchCount).is_displayed()

    def displayresultTitle(self):
        return self.driver.find_element_by_xpath(self.resultTitle).is_displayed()

    def displayitemsPerPage(self):
        return self.driver.find_element_by_xpath(self.itemsPerPage).is_displayed()

    def displaybtn_NextPage(self):
        return self.driver.find_element_by_xpath(self.btn_NextPage).is_displayed()

    def displaybtn_NextPage_disabled(self):
        return self.driver.find_element_by_xpath(self.btn_NextPage_disabled).is_displayed()

    def clickbtn_NextPage(self):
        self.driver.find_element_by_xpath(self.btn_NextPage).click()

    def list_of_elements(self):
       return self.driver.find_elements_by_xpath(self.resultTitle)
    def get_itemsPerPage(self):
       return self.driver.find_element_by_xpath(self.itemsPerPage)


