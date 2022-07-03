using BDDSpecFlowProject.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDSpecFlowProject.Hooks
{
    [Binding]
   public sealed class HooksTest
    {
        private DriverHelper _driverHelper;
       //WebDriver _driver;
        public HooksTest(DriverHelper driveHelper)
        {
            _driverHelper = driveHelper;
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            _driverHelper.Driver = new ChromeDriver(option);
          //  Console.WriteLine("Test tset");
          //  // _driver = new ChromeDriver();
          //  _driverHelper = new ChromeDriver();
          //  _driverHelper.Manage().Window.Maximize();
          ////  _driver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login");
          //  _driver.Url= "http://eaapp.somee.com/Account/Login";

            //SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            //_scenarioContext.Set(seleniumDriver, "SeleniumDriver");

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
