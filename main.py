from selenium import webdriver
import time
from selenium.webdriver.common.action_chains import ActionChains

driver = webdriver.Chrome()
driver.maximize_window()

driver.get("https://jqueryui.com/droppable/")
driver.switch_to_frame(driver.find_element_by_xpath("//iframe[@class='demo-frame']"))

source = driver.find_element_by_xpath("//*[text()='Drag me to my target']")
target = driver.find_element_by_xpath("//*[text()='Drop here']")

actions = ActionChains(driver)
actions.drag_and_drop(source, target).perform()
time.sleep(5)