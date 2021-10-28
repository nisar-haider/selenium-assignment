import unittest
import HtmlTestRunner
import sys
sys.path.append("C:/Users/Duraze/PycharmProjects/pythonProject")
from Configurations.config import config1

class driver1(config1):

    def callID(self):
        return (self.id())

    def run_all_suites(self):

        test_suite = unittest.TestSuite()
        # Load all test case class in current folder.
        all_test_cases = unittest.defaultTestLoader.discover('.', '*.py')
        for test_case in all_test_cases:
            test_suite.addTests(test_case)

        test_runner = HtmlTestRunner.HTMLTestRunner(output='../Reports',report_name="Test Suites Report",report_title="Complete Test Suites", combine_reports=True, template='../image.html')
        test_runner.run(test_suite)






if __name__=='__main__':

    driver1.run_all_suites(self=driver1)








