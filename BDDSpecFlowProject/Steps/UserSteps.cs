using AutoFixture;
using System;
using TechTalk.SpecFlow;

namespace BDDSpecFlowProject.Steps
{
    [Binding]
    public class UserSteps
    {
        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            var person = new Fixture()
                .Build<User>()
                .With(x => x.Email, "cyrax.cr@test.com")
                .Create();
            Console.WriteLine($"The user {person.Name} has email {person.Email} and his Address {person.Address} with phome number {person.Phone}");
        }
        
        [Given(@"I input dynamic domain for (.* email)")]
        public void GivenIInputDynamicDomainForCyrax_CyTest_ComEmail(string email)
        {
            Console.WriteLine($"The Random email address is: {email}");
        }
        public record User {
            public string Name { get; init; }
            public string Email {get; init; }
            public string Address { get; init; }
            public string Phone { get; init; }

        }
    }
    
}
