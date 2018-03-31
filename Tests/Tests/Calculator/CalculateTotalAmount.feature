Feature: CalculateTotalAmount
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I create a new property (<Principal>,<PercantageRate>,<Years>)
	When I press add
	Then the result should be 1,0612080000000002 on the screen

Examples: 
| Principal | PercentageRate | Years |
|     1     |        2       |   3   | 