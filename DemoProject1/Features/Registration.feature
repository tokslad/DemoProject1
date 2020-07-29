Feature: Registration
	In order to use Amazon website
	I will need to register
	So that i can enjoy all the amazing offers
	
@mytag
Scenario: Valid Registration
	Given I navigate to Amazon website
	When I click on the hello sign in
	And I click on create your amazon account on page
	And I enter my name
	And I enter my email
	And I enter my password on page
	And I reenter my password again
	And I click on create your account on registration page
	Then my account should be created 
