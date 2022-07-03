Feature: EaLogin
	To verify login functionality

@mytag
Scenario: Verify login functionality for ea
	Given User is on the login page
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then I should see user logged in to the application