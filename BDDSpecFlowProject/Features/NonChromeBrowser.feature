Feature: NonChromeBrowser
	Testing non chrome browser

@ToDoApp
Scenario: Add items to the ToDoApp - Firefox
	Given I navigate to LambdaTest app on the following environment
	| Browser | BrowserVersion | OS        |
	| FireFox | 102.0           | Windos 10 |
	And I select the first item 
	And I select the second item 
	And I enter the new value in Textbox
	When I click the submit button
	Then I verify whether the item is added to the list