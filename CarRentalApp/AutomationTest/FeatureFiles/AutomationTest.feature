Feature: AutomationTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 15 into the calculator
	When I add 5
	Then the result should be 20 on the screen



Scenario Outline: Add multiple numbers
	Given I have entered <number1> into the calculator
	When I add <number2>
	Then the result should be <result> on the screen
	Examples: 
	| number1 | number2 | result |
	| 7       | 6       | 13     |
	| 21      | 9       | 30     |
	| 105     | 400     | 505    |
