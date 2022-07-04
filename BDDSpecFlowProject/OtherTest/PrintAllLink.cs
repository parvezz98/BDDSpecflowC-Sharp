using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class PrintAllLink
    {
        [Test]
        public static void getAllLinks() {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("start-maximized");
            IWebDriver drvr = new ChromeDriver(opt);
            drvr.Url = "http://eaapp.somee.com/Account/Login";
            drvr.Manage().Timeouts().ImplicitWait=(TimeSpan.FromSeconds(30));
            IList<IWebElement> el = drvr.FindElements(By.TagName("a"));
            Console.WriteLine(el.Count);
            
            for (int i = 0; i < el.Count; i++)
            {
                Console.WriteLine(el[i].Text);
            }
            el[7].Click();
            Thread.Sleep(2000);
            drvr.Quit();
        }
    }
}
