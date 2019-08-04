using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SecondAttemptFirstSelenium
{
    class Program
    {
        private IWebDriver driver = new ChromeDriver();

        //static void Main(string[] args)
        //{
        // IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("http://www.google.com");
        // }

        [SetUp]
        public void Initialize()
        {
            if (driver==null)
                driver = new ChromeDriver();

            Console.WriteLine("Navigate to site");
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
        }

        [Test]
        public void ExecuteTest()
        {
            Console.WriteLine("Execute Test");
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Selenium", "Name");
            SeleniumSetMethods.Click(driver, "Save", "Name");


            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("selenium");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("driver close");
            driver.Close();
            driver = null;
        }


    }
}
