Feature: Calculations

@Calculations @200
Scenario Outline: Check calculations

Given I create a new property <Principal>, <PercentageRate>, <Years>
Then the calculation should return <Result>
And the system should return OK

Examples: 
| Principal | PercentageRate | Years | Result             |
| 2         | 1              | 3     | 2.0606020000000003 |
| 1000      | 2              | 5     | 1104.0808032       |

@400
Scenario: When added ridicoulous number to calculation a BadRequest is responded
Given I create a new property 1000, 2, 40000
Then the system should return BadRequest


@500
Scenario: Check calculation with empty property

Given I create empty property
Then the system should return InternalServerError

@401
Scenario: Check calculation with unauthorized ApiKey

Given I create calculation request with unathorized ApiKey
Then the system should return Unauthorized