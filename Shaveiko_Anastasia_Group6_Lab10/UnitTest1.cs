using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Shaveiko_Anastasia_Group6_Lab10
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver chromeDriver;
        [TestMethod]
        public void TestMethod1()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("http://www.google.by/");
            chromeDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("iTechArt");
            chromeDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys(Keys.Enter);
            Assert.IsTrue(chromeDriver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]")).Text.Contains("iTechArt"));
            Assert.IsTrue(chromeDriver.Title.Contains("iTechArt"));
        }
        [TestCleanup]
        public void TearDown()
        {
            chromeDriver.Quit();
        }
    }
}
