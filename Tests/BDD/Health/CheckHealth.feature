Feature: CheckHealth
	In order to check if the api is working
	I want to see if everything is ok

@mytag
Scenario: Check application health
	Given I request to check the application status
	Then the system should return OK
