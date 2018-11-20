Feature: Calculate
	Calculator

@mytag
Scenario: Add numbers in UWP calculator of Windows 10
	Given I open the application
	And I click following numbers
		| Numbers |
		| Five    |
		| Six     |
	And I perform Addition operation
	And I click following numbers
		| Numbers |
		| Seven   |
	And I click Equals
	Then I should see the result as 63

	
