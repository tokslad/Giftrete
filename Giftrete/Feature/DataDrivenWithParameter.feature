Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Registration
	Given I navigate to site "https://www.qa.giftrete.com/"
	When I click on craete account
	And I enter first Name "jane"
	And I enter Last name "doe"
	And I enter Email "doejane"
	And I select the flag container
	And I select United Kingdom as country
	And I type in mobile number
	And I enter Password "Bluesky007"
	And I Reenter password "Bluesky007"
	And I click on Register
	Then I'm taking to sign in page


	


