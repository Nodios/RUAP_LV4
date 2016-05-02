using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Untitled5
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://demo.opencart.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browserdfgh
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestCase]
        public void TheUntitled5Test()
        {
            driver.Navigate().GoToUrl(baseURL + "/index.php?route=common/home");
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("vajak3@vojak.com");
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("Password123");
            driver.FindElement(By.CssSelector("input.btn.btn-primary")).Click();
            driver.FindElement(By.LinkText("Monitors (2)")).Click();
            driver.FindElement(By.LinkText("Samsung SyncMaster 941BW")).Click();
            driver.FindElement(By.Id("input-quantity")).Clear();
            driver.FindElement(By.Id("input-quantity")).SendKeys("5646546354");
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[5]")).Click();
            driver.FindElement(By.CssSelector("a > strong")).Click();
            driver.FindElement(By.Name("quantity[YToxOntzOjEwOiJwcm9kdWN0X2lkIjtpOjMzO30=]")).Clear();
            driver.FindElement(By.Name("quantity[YToxOntzOjEwOiJwcm9kdWN0X2lkIjtpOjMzO30=]")).SendKeys("666");
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();
            driver.FindElement(By.CssSelector("a.btn.btn-primary")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
