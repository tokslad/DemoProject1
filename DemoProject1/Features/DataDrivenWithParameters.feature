Feature: DataDrivenWithParameters
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameters
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When I enter username test "doejanem"
	And I enter email test "doe"
	And I enter password test "Adel0nd0n"
	And I click on Sign in buuton
	Then I am logged in with my username displayed
