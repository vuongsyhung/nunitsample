using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium
{
    [TestFixture]
    public class GoogleSearchTest
    {
        IWebDriver driver;
        public string Ulr = "https://www.google.com/?hl=vi";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown() 
        {
            Thread.Sleep(10000);
            driver.Dispose();
        }

        [Test]
        public void Search()
        {
            // Di den trang nao do
            driver.Navigate().GoToUrl(Ulr);

            // Tim the html co ten q
            // Sau do go vao the q noi dung "Truong Thpt To Hien Thanh"
            driver.FindElement(By.Name("q")).SendKeys("Truong Thpt To Hien Thanh");

            // Tim the html button co ten K
            // Tiep theo lay thanh phan [1]
            driver.FindElements(By.Name("btnK"))[1].Click();
        }
    }
}
