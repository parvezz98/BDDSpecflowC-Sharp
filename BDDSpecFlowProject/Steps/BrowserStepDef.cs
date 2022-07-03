using BDDSpecFlowProject.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BDDSpecFlowProject.Steps
{
    [Binding]
    public class BrowserStepDef
    {
       // IWebDriver driver;
       //private readonly ScenarioContext _scenarioContext;

       //public  BrowserStepDef(ScenarioContext scenarioContext) {
       //     _scenarioContext = scenarioContext;
       // }

       // [Given(@"I navigate to LambdaTest app on the following environment")]
       // public void GivenINavigateToLambdaTestAppOnTheFollowingEnvironment(Table table)
       // {
       //     driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
       //     driver.Url = "https://lambdatest.github.io/sample-todo-app/";
       // }
        
       // [Given(@"I select the first item")]
       // public void GivenISelectTheFirstItem()
       // {
       //     driver.FindElement(By.Name("li1")).Click();
       // }
        
       // [Given(@"I select the second item")]
       // public void GivenISelectTheSecondItem()
       // {
       //     driver.FindElement(By.Name("li2")).Click();
       // }
        
       // [Given(@"I enter the new value in Textbox")]
       // public void GivenISelectTheThirdItem()
       // {
       //     driver.FindElement(By.Id("sampletodotext")).SendKeys("Passing some value");
       // }
        
       // [When(@"I click the submit button")]
       // public void WhenIClickTheSubmitButton()
       // {
       //     driver.FindElement(By.Id("addbutton")).Click();
       // }
        
       // [Then(@"I verify whether the item is added to the list")]
       // public void ThenIVerifyWhetherTheItemIsAddedToTheList()
       // {
       //    // Assert.That(driver.FindElement(By.XPath("/html/body/div/div/div/form/input[1]").Text)
       //     IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/form/input[1]"));
       //     String getText = itemtext.Text;

       //     // Check if the newly added item is present or not using
       //     // Condition constraint (Boolean)
       //     Assert.That(("MI".Contains(getText)), Is.True);

       //     /* Perform wait to check the output */
       //     System.Threading.Thread.Sleep(2000);

       //     Console.WriteLine("Firefox - Test Passed");
       // }
    }
}
