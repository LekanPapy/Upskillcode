Feature: Project
	
Scenario: API_Project_01_Verify that an existing records can be retrieved from Project resource
	Given that TaskManagementSystem web services with GET endpoint /Projects is running
	Then the status code for GET endpoint is equal to OK
	And the following records should be retrieved from Projects table
	| Name                |
	| Performance Testing |
	| Geography           |
	| Mobile Testing      |
	| Computer Science    |


Scenario: API_Project_02_Verify that a new Projects record can be created 
	Given that TaskManagementSystem web services with POST endpoint /Projects is running
	Then the status code for POST endpoint is equal to Created
	And the response description for POST endpoint is equal to Created

Scenario: API_Project_03_Verify that an existing Projects record can be modified 
	Given that TaskManagementSystem web services with PUT endpoint /Projects is running
	Then the status code for PUT endpoint is equal to NoContent
	And the response description for PUT endpoint is equal to No Content

Scenario: API_Project_04_Verify that an existing record can be deleted from Project resource
	Given that TaskManagementSystem web services with DELETE endpoint /Projects is running
	Then the status code for DELETE endpoint is equal to OK
	And the response description for DELETE endpoint is equal to OK
