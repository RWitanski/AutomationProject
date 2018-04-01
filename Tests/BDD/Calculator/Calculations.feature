Feature: Calculations

@Calculations @200
Scenario Outline: Check calculations

Given I create a new property <Principal>, <PercentageRate>, <Years>
Then the calculation should return <Result>
And the system should return <StatusCode>

Examples: 
| Principal | PercentageRate | Years | Result             | StatusCode |
| 2         | 1              | 3     | 2.0606020000000003 | OK         |
| 1000      | 2              | 5     | 1104.0808032       | OK         |

@400
Scenario: Check if when added ridicoulous number a BadRequest is responded


@500
Scenario: Check calculation with empty property

Given I create empty property
Then the system should return InternalServerError

@401
Scenario: Check calculation with unauthorized ApiKey

Given I create calculation request with unathorized ApiKey
Then the system should return Unauthorized