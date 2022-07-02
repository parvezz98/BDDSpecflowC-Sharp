using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDSpecFlowProject.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        [BeforeTestRun]
        public static void BeforeTest() { // By default these methods should be static as per SpecFlow Doc
            Console.WriteLine("******** This Line will execute Before Test ****");
        }
        [BeforeFeature]
        public static void BeforeFeature() {
            Console.WriteLine("******** This should be executed before feature ****");
        }
        [BeforeScenario("regression")]
        public static void BeforeScenario()
        {
            Console.WriteLine("******** This should be executed before Scenario ****");
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("******** This should be executed After Scenario ****");
        }
    }
}
