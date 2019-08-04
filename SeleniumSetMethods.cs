using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondAttemptFirstSelenium
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string locatorType)
        {
            if (locatorType == "id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (locatorType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        //Click Button CheckBox Options
        public static void Click(IWebDriver driver, string element, string locatorType)
        {
            if (locatorType == "id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (locatorType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }
        //Select
        public static void SelectDropDown(IWebDriver driver, string element, string value, string locatorType)
        {
            if (locatorType == "id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (locatorType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
