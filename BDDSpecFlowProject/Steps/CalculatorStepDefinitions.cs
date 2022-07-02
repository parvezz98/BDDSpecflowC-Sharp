using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDSpecFlowProject.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 


        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
        }


            [When("the two numbers are added")]
            public void WhenTheTwoNumbersAreAdded()
            {
                //TODO: implement act (action) logic


            }

            [Then("the result should be (.*)")]
            public void ThenTheResultShouldBe(int result)
            {

            }
        [Then(@"So Result should be passed")]
        public void ThenSoResultShouldBePassed()
        {
            Console.WriteLine("Double is tracked");
        }
        [Given(@"I input following numbers to the calculater")]
        public void GivenIInputFollowingNumbersToTheCalculater(Table table)
        {
            dynamic data1 = table.CreateDynamicSet();
            foreach(var item in data1){
                Console.WriteLine("The numbers are " + item.Numbers);
            }
        }
        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The Result is going to hold the value {data.Results} with logo {data.Logo}");
        }
        [Then(@"result should be ""(.*)""")]
        public void ThenResultShouldBe(string p0)
        {
            Console.WriteLine("Passed");
        }




    }
}
