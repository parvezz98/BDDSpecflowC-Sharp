using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace BDDSpecFlowProject.OtherTest
{
    class WebDriverWaitest
    {
        [Test]
        public static void checkWDwait() {
            ChromeOptions opt= new ChromeOptions();
            opt.AddArguments("start-maximized");
            IWebDriver driver= new ChromeDriver(opt);
            driver.Url = "http://eaapp.somee.com/Account/Login";
            WebDriverWait wt = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement ie = wt.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//center/a")));
            Boolean flag = ie.Displayed;
            Console.WriteLine(flag);


        }


    }
}
