using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDSpecFlowProject.Drivers
{
    public class SeleniumDriver
    {
        //    private IWebDriver driver;
        //    private readonly ScenarioContext _scenarioContext;
        //    public SeleniumDriver(ScenarioContext scenarioContext)
        //    {
        //        _scenarioContext = scenarioContext;
        //    }
        //    // {{  "browserName": "firefox",  "moz:firefoxOptions": {}}}
        //    public IWebDriver Setup() {
        //        var firefoxOptions = new FirefoxOptions();
        //     //   driver = new RemoteWebDriver(new Uri("http://" + username + ":" + accesskey + "hub.lambdatest.com/wd/hub"), capability);
        //       driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),firefoxOptions.ToCapabilities());

        //        //set the Driver
        //        _scenarioContext.Set(driver, "WebDriver");
        //        driver.Manage().Window.Maximize();
        //        return driver;
        //    }
        //}
    }
}
