Feature: Student
	As a Course Management System user
	I should be able to Create, Modify, View and Delete
	A student record

#Prerequisite: a student record Wayne Rooney should be deleted
Scenario: Student_01_Verify that a user can create a new student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in FamilyName field with Wayne
	And a user fills-in FirstName field with Rooney
	And a user fills-in Enrollment Date with 2019/10/10
	And a user clicks on Create button
	Then a new student record Wayne should be created

#This is another way of writing the above test
#Prerequisite: a student record Wayne Rooney should be deleted
Scenario: Student_02_Use a table format to verify that a user can create a new student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in new student record form page with below data
	| FamilyName | FirstName | EnrollmentDate |
	| Wayne      | Rooney    | 2019/10/10     |	
	And a user clicks on Create button
	Then a new student record Wayne should be created

#Prerequisite: All student records in the table below should be deleted
Scenario Outline: Student_03_Verify that multiple student records can be created
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in a new student form page with <FamilyName>, <FirstName>, <EnrollmentDate> fields
	And a user clicks on Create button
	Then a new student record <ExpectedResult> should be created
	Examples: 
	| FamilyName | FirstName | EnrollmentDate | ExpectedResult |
	| Paul       | Smith     | 2019/10/10     | Paul           |
	| Tom        | Jerry     | 2019/10/10     | Tom            |
	| Frank      | Lampard   | 2019/10/10     | Frank          |
	| Joy        | Lola      | 2019/10/10     | Joy            |

Scenario Outline: Student_04_Verify that a new student record cannot be created with incorrect input data
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in a new student form page with <FamilyName>, <FirstName>, <EnrollmentDate> fields
	And a user clicks on Create button
	Then a new student record <ExpectedErrorMessage> should be created
	Examples: 
	| FamilyName | FirstName | EnrollmentDate | ExpectedErrorMessage        |
	| Paul       |           | 2019/10/10     | First name is required      |
	|            | Smith     | 2019/10/10     | Last name is required       |
	| Paul       | Smith     |                | Enrollment date is required |

#Prerequisite: student records Wayne Rooney and Ted Baker should be deleted
#Prerequisite: student records Wayne Rooney and Ted Baker should be added to the Person table
Scenario: Student_05_Verify that a user can modify an existing student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Edit link
	And a user fills-in FamilyName field with Wayne
	And a user fills-in FirstName field with Rooney
	And a user fills-in Enrollment Date with 2019/10/10
	And a user clicks on Save button
	Then a new student record Wayne should be created

#Prerequisite: a student record Ted Baker should be deleted
#Prerequisite: a student record Ted Baker should be in Person table
Scenario: Student_06_Verify that a user can delete an existing student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Delete link
	And a user clicks on Delete button on the form page	
	Then a student record Ted should not be present 














	