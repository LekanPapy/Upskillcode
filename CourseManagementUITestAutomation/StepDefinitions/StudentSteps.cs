using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using CourseManagementUITestAutomation.Hooks;
using CourseManagementUITestAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow.Assist;
using CourseManagementUITestAutomation.Model;
using System.Threading;

namespace CourseManagementUITestAutomation.StepDefinitions
{
    [Binding]
    public class StudentSteps
    {        
        StudentPage studentPage;
        DatabaseHelper databaseHelper;

        public StudentSteps(StudentPage _studentPage, DatabaseHelper _databaseHelper)
        {            
            studentPage = _studentPage;
            databaseHelper = _databaseHelper;
        }        

        [When(@"a user clicks on Students link")]
        public void WhenAUserClicksOnStudentsLink()
        {
            databaseHelper.ClearStudentRecordInPersonTable();
            studentPage.ClickOnStudentLink();
        }

        [When(@"a user clicks on Create New link")]
        public void WhenAUserClicksOnCreateNewLink()
        {
            studentPage.ClickOnCreateNewLink();
        }

        [When(@"a user fills-in FamilyName field with (.*)")]
        public void WhenAUserFills_InFamilyNameFieldWithHaka(string familyName)
        {
            studentPage.FillInFamilyName(familyName);
        }

        [When(@"a user fills-in FirstName field with (.*)")]
        public void WhenAUserFills_InFirstNameFieldWithBoyboy(string firstName)
        {
            studentPage.FillInFirstName(firstName);
        }

        [When(@"a user fills-in Enrollment Date with (.*)")]
        public void WhenAUserFills_InEnrollmentDateWith(string enrollmentDate)
        {
            studentPage.FillInEnrollmentDate(enrollmentDate);
        }

        [When(@"a user clicks on Create button")]
        public void WhenAUserClicksOnCreateButton()
        {
            studentPage.ClickOnCreateButton();
        }

        [Then(@"a new student record (.*) should be created")]
        public void ThenANewStudentRecordHakaShouldBeCreated(string expectedResult)
        {
            //string actualResult = studentPage.VerifyStudentRecordCreation();
            //string expectedResult = "http://localhost/CourseManagementSystem/students";
            //Assert.AreEqual(expectedResult, actualResult);
            bool actualResult = studentPage.ActualResultVerification(expectedResult);
            Assert.IsTrue(actualResult, $"actual result {actualResult} is not equal to an expected result {expectedResult}");
        }
       
        [When(@"a user fills-in new student record form page with below data")]
        public void WhenAUserFills_InNewStudentRecordFormPageWithBelowData(Table table)
        {
            var tableList = table.CreateInstance<StudentModel>();
            studentPage.FillInFamilyName(tableList.FamilyName);
            studentPage.FillInFirstName(tableList.FirstName);
            studentPage.FillInEnrollmentDate(tableList.EnrollmentDate);
        }

        [When(@"a user fills-in a new student form page with (.*), (.*), (.*) fields")]
        public void WhenAUserFills_InANewStudentFormPageWithPaulSmithFields(string familyName, string firstName, string enrollmentDate)
        {
            studentPage.FillInFamilyName(familyName);
            studentPage.FillInFirstName(firstName);
            studentPage.FillInEnrollmentDate(enrollmentDate);
        }    

        [When(@"a user clicks on Edit link")]
        public void WhenAUserClicksOnEditLink()
        {
            databaseHelper.PopulatePersonTableWithStudentRecord();
            studentPage.ClickOnEditButton();
        }

        [When(@"a user clicks on Save button")]
        public void WhenAUserClicksOnSaveButton()
        {
            studentPage.ClickOnSaveButton();
        }

        [When(@"a user clicks on Delete link")]
        public void WhenAUserClicksOnDeleteLink()
        {
            databaseHelper.PopulatePersonTableWithStudentRecord();
            studentPage.ClickOnDeleteLink();
        }

        [When(@"a user clicks on Delete button on the form page")]
        public void WhenAUserClicksOnDeleteButtonOnTheFormPage()
        {
            studentPage.ClickOnDeleteButton();
        }

        [Then(@"a student record (.*) should not be present")]
        public void ThenAStudentRecordTedShouldNotBePresent(string expectedResult)
        {
            bool actualResult = studentPage.ActualResultVerification(expectedResult);
            Assert.IsFalse(actualResult, $"actual result {actualResult} is not equal to an expected result {expectedResult}");
        }

        [Then(@"an error message (.*) should be displayed")]
        public void AnErrorMessageShouldBeDisplayed(string expectedErrorMessage)
        {
            string actualErrorMessage = string.Empty;

            if (expectedErrorMessage.Equals("First name is required"))
            {
                actualErrorMessage = studentPage.ReturnFirstNameErrorMessage();
                Thread.Sleep(2000);
            }
            else if (expectedErrorMessage.Equals("Last name is required"))
            {
                actualErrorMessage = studentPage.ReturnFamilyNameErrorMessage();
                Thread.Sleep(2000);
            }
            else if (expectedErrorMessage.Equals("Enrollment date is required"))
            {
                actualErrorMessage = studentPage.ReturnEnrollmentDateErrorMessage();
                Thread.Sleep(2000);
            }

            Assert.AreEqual(expectedErrorMessage, actualErrorMessage, $"{expectedErrorMessage} is not equal to {actualErrorMessage}");
        }

    }
}
