using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class CountTotalElemet
    {
        [Test]
        public static void countTotlElement() {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Cisco");
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys(Keys.Enter);
            IList<IWebElement> lst = driver.FindElements(By.XPath("//h3[starts-with(text(),'Cisco')]"));
            for (int i = 0; i < lst.Count; i++) {
                Console.WriteLine(lst[i].Text);
            }
        }
    }
}
