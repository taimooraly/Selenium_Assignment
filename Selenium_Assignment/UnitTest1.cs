using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace Selenium_Assignment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", "Admin", "admin123")]
        
        public void TestMethod1(string url, string user, string pass)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.FindElement(By.ClassName("oxd-input oxd-input--active")).SendKeys(user);
            driver.FindElement(By.Name("password")).SendKeys(pass);
            driver.FindElement(By.ClassName("oxd-button oxd-button--medium oxd-button--main orangehrm-login-button")).Click();
            string newUrl = driver.Url;
            Assert.AreEqual("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index", newUrl);
            driver.Close();
        }
    }
} 
