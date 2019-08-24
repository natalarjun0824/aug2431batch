using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPracticeSite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenGoogleBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            //Open a browser
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            Assert.IsTrue(searchBox.Displayed);
        }

        [TestMethod]
        public void SearchMobileLegends()
        {
            IWebDriver driver = new ChromeDriver();
            //Open a browser
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            IWebElement SearchBtn = driver.FindElement(By.Name("btnK"));
            //input value on search box
            searchBox.SendKeys("Mobile Legends" + Keys.Enter);
            Assert.IsTrue(searchBox.Displayed);

            //h1(text(), "Authentication")
        }
    }
}
