using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumtrainingAug
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod][TestCategory("Smoke")]
        public void RegisterUser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//a[contains(text(), 'REGISTER')]")).Click();
       
            IWebElement FirstName = driver.FindElement(By.Name("firstName"));
            Assert.AreEqual("", FirstName.Text);
            IWebElement LastName = driver.FindElement(By.Name("lastName"));
            IWebElement Phone = driver.FindElement(By.Name("phone"));
            IWebElement Address1 = driver.FindElement(By.Name("address1"));
            IWebElement Address2 = driver.FindElement(By.Name("address2"));
            IWebElement City = driver.FindElement(By.Name("city"));

            SelectElement Country = new SelectElement(
                                driver.FindElement(By.Name("country")));
            Country.SelectByText("ANGOLA");
            Country.SelectByIndex(4);
            

            IWebElement State = driver.FindElement(By.Name("state"));
            IWebElement PostalCode = driver.FindElement(By.Name("postalCode"));

            IWebElement Email = driver.FindElement(By.Name("email"));
            IWebElement Password = driver.FindElement(By.Name("password"));
            IWebElement ConfirmPassword = driver.FindElement(By.Name("confirmPassword"));

            IWebElement Register = driver.FindElement(By.Name("register"));

            
            FirstName.SendKeys("Arjun");
            LastName.SendKeys("Natal");

        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void LoginUser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
            Thread.Sleep(10000);

            IWebElement UserNameTxt = driver.FindElement(By.Name("userName"));
            IWebElement PassWordTxt = driver.FindElement(By.Name("password"));
            IWebElement LoginBtn = driver.FindElement(By.Name("login"));

            //IWebElement authenticate = driver.FindElement(By.XPath("//*[@id=\"center_column\"]/h1"));
            //IWebElement authenticate1 = driver.FindElement(By.XPath("//h1[contains(text(), 'Authentication')]"));
            
          
            //IWebElement authenticateBySelector = driver.FindElement(By.CssSelector("#center_column > h1"));
            //IWebElement authenticateBySelector1 = driver.FindElement(By.CssSelector("h3[class='page-subheading']"));
            
            UserNameTxt.SendKeys("trainee101");
            PassWordTxt.SendKeys("abc123");
            LoginBtn.Click();

        }
    }
}
