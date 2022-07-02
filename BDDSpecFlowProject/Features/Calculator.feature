Feature: Calculator

@smoke
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	Then So Result should be passed

Scenario: Working with Tables
    Given I input following numbers to the calculater
	| Numbers |
	| 50      |
	| 80      |
	Then I see the result and few more details
	| Results | Logo |
	| 130     | plus |
	Then result should be "Passed"
