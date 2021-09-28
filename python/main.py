from selenium import webdriver
import time
from selenium.webdriver.common.action_chains import ActionChains
from Pages.TTHomePage import TTHomePage
from Pages.Google import GooglePage
from Pages.Portfolio import Portfolio

driver = webdriver.Chrome()
driver.maximize_window()

driver.get("https://www.google.com/")
# driver.switch_to_frame(driver.find_element_by_xpath("//iframe[@class='demo-frame']"))
#
# source = driver.find_element_by_xpath("//*[text()='Drag me to my target']")
# target = driver.find_element_by_xpath("//*[text()='Drop here']")
#
# actions = ActionChains(driver)
# actions.drag_and_drop(source, target).perform()

googlepage = GooglePage(driver)
ttHome = TTHomePage(driver)
portfolio = Portfolio(driver)

googlepage.searchInput("Tintash")
googlepage.clickSearchButton()
driver.implicitly_wait(5)
googlepage.clickTintashLink()

ttHome.clickPortfolio()

time.sleep(2)
#portfolio.displayTxtPortfolio()

Element = driver.find_element_by_xpath("//span[text()='View Casestudy']")
driver.execute_script("arguments[0].scrollIntoView();", Element)

#portfolio.displaydd_Solution()
portfolio.clickdd_Solution()
portfolio.clickchkbox_ddL_Solution()

#portfolio.displaydd_Technology()
portfolio.clickdd_Technology()
portfolio.clickchkbox_ddL_Technology()

#portfolio.displaydd_Industry()
portfolio.clickdd_Industry()

Element1 = driver.find_element_by_xpath("//*[text()='Retail & eCommerce']")
driver.execute_script("arguments[0].scrollIntoView();", Element1)
portfolio.clickchkbox_ddL_Industry()





time.sleep(5)