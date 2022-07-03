using BDDSpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDSpecFlowProject.Hooks
{
    [Binding]
    public sealed class HooksInitialization
    {
        //// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //private readonly ScenarioContext _scenarioContext;
        //public HooksInitialization(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
        //    _scenarioContext.Set(seleniumDriver, "SeleniumDriver");

        //    //TODO: implement logic that has to run before executing each scenario
        //}

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    Console.WriteLine("Selenium Webdriver Quit");
        //    _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        //}
    }
}
