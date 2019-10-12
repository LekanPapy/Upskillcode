Feature: Student
	As a Course Management System user
	I should be able to Create, Modify, View and Delete
	A student record

Scenario: Verify that a user can create a new student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in FamilyName field with Wayne
	And a user fills-in FirstName field with Rooney
	And a user fills-in Enrollment Date with 2019/10/10
	And a user clicks on Create button
	Then a new student record Wayne should be created


