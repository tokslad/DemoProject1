﻿Feature: DataDrivenWithExamples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Examples
	Given I navigate to "https://angularjs.realworld.io/#/register"
	When the user enter Username text "<Username>"
	And the user enter email text "<Email>"
	And the user enter password text "<Password>"
	#And I click on Sign in buuton
	#Then I am logged in with my username displayed

	Examples: 

	| Username | Email | Password  |
	| Doe      | Doe   | Adel0nd0n |
	| Doe2     | Doe   | Adel0nd0n2|

