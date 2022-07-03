using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
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

        //Global Variable for Extend report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private DriverHelper _driverHelper;
       //WebDriver _driver;
        public HooksTest(DriverHelper driveHelper)
        {
            _driverHelper = driveHelper;
        }
        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\user\source\repos\BDDSpecFlowProject\BDDSpecFlowProject\Reports\Report.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);
        }
        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
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
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
        [AfterStep]
        public void InsertReportingSteps()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        }
        }
}
