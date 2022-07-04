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
    class HandleSecureWarning
    {
        [Test]
        public static void handleSecure() {
            ChromeOptions op = new ChromeOptions();
            op.AddArguments("start-maximized");
            op.AcceptInsecureCertificates=true;
            IWebDriver dr = new ChromeDriver(op);
            dr.Url = "http://eaapp.somee.com/Account/Login";
            
            dr.Quit();
           // op.SetLoggingPreference
        }
    }
}
