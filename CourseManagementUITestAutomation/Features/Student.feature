Feature: Student
	As a Course Management System user
	I should be able to Create, Modify, View and Delete
	A student record

#Prerequisite: a student record Wayne Rooney should be deleted
Scenario: Student_01_Verify that a user can create a new student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in FamilyName field with WayneTest1
	And a user fills-in FirstName field with RooneyTest1
	And a user fills-in Enrollment Date with 2019/10/10
	And a user clicks on Create button
	Then a new student record RooneyTest1 should be created

#This is another way of writing the above test
#Prerequisite: a student record Wayne Rooney should be deleted
Scenario: Student_02_Use a table format to verify that a user can create a new student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in new student record form page with below data
	| FamilyName | FirstName   | EnrollmentDate |
	| WayneTest2 | RooneyTest2 | 2019/10/10     |	
	And a user clicks on Create button
	Then a new student record WayneTest2 should be created

#Prerequisite: All student records in the table below should be deleted
Scenario Outline: Student_03_Verify that multiple student records can be created
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in a new student form page with <FamilyName>, <FirstName>, <EnrollmentDate> fields
	And a user clicks on Create button
	Then a new student record <ExpectedResult> should be created
	Examples: 
	| FamilyName | FirstName   | EnrollmentDate | ExpectedResult |
	| WayneTest3 | RooneyTest3 | 2019/10/10     | WayneTest3     |
	| WayneTest4 | RooneyTest4 | 2019/10/10     | WayneTest4     |
	| WayneTest5 | RooneyTest5 | 2019/10/10     | WayneTest5     |
	| WayneTest6 | RooneyTest6 | 2019/10/10     | WayneTest6     |
	| WayneTest7 | RooneyTest7 | 2019/10/10     | WayneTest7     |

Scenario Outline: Student_04_Verify that a new student record cannot be created with incorrect input data
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Create New link
	And a user fills-in a new student form page with <FamilyName>, <FirstName>, <EnrollmentDate> fields
	And a user clicks on Create button
	Then an error message <ExpectedErrorMessage> should be displayed
	Examples: 
	| FamilyName  | FirstName    | EnrollmentDate | ExpectedErrorMessage        |
	| WayneTest8  |              | 2019/10/10     | First name is required      |
	|             | RooneyTest9  | 2019/10/10     | Last name is required       |
	| WayneTest10 | RooneyTest10 |                | Enrollment date is required |

#Prerequisite: student records WayneTest11 RooneyTest11 and WayneTest12 RooneyTest12 should be deleted
#Prerequisite: student record WayneTest11 RooneyTest11 should be added to the Person table
Scenario: Student_05_Verify that a user can modify an existing student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Edit link
	And a user fills-in FamilyName field with WayneTest12
	And a user fills-in FirstName field with RooneyTest12
	And a user fills-in Enrollment Date with 2019/10/10
	And a user clicks on Save button
	Then a new student record WayneTest12 should be created

#Prerequisite: student record WayneTest11 RooneyTest11 should be deleted
#Prerequisite: student record WayneTest11 RooneyTest11 should be added to the Person table
Scenario: Student_06_Verify that a user can delete an existing student record
	Given that CMS application is loaded
	When a user clicks on Students link
	And a user clicks on Delete link
	And a user clicks on Delete button on the form page	
	Then a student record WayneTest11 should not be present 














	