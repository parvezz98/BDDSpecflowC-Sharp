using BDDSpecFlowProject.Drivers;
using BDDSpecFlowProject.Hooks;
using BDDSpecFlowProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDSpecFlowProject.Steps
{
    [Binding]
    public class EaLoginSteps
    {
        private DriverHelper _driverHelper;
        LoginPage loginPage;
        //  IWebDriver driver;
        public EaLoginSteps(DriverHelper driverHelper) {
            _driverHelper = driverHelper;
            loginPage = new LoginPage(_driverHelper.Driver);
        }
        [Given(@"User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            //HooksTest s = new HooksTest(driver);
            // Console.WriteLine("Test is done");
            _driverHelper.Driver.Url = "http://eaapp.somee.com/Account/Login";
        }
        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword(data.UserName, data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Console.WriteLine("Test is done");
        }

    }
}
