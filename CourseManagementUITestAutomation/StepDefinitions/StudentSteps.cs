using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using CourseManagementUITestAutomation.Hooks;
using CourseManagementUITestAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            //databaseHelper.ClearStudentRecordInPersonTable();
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
        public void ThenANewStudentRecordHakaShouldBeCreated(string familyName)
        {
            string actualResult = studentPage.VerifyStudentRecordCreation();
            string expectedResult = "http://localhost/CourseManagementSystem/students";
            Assert.AreEqual(expectedResult, actualResult);
        }
       
        [When(@"a user fills-in new student record form page with below data")]
        public void WhenAUserFills_InNewStudentRecordFormPageWithBelowData(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user fills-in a new student form page with (.*), (.*), (.*) fields")]
        public void WhenAUserFills_InANewStudentFormPageWithPaulSmithFields(string familyName, string firstName, string enrollmentDate)
        {
            ScenarioContext.Current.Pending();
        }    

        [When(@"a user clicks on Edit link")]
        public void WhenAUserClicksOnEditLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user clicks on Save button")]
        public void WhenAUserClicksOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user clicks on Delete link")]
        public void WhenAUserClicksOnDeleteLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a user clicks on Delete button on the form page")]
        public void WhenAUserClicksOnDeleteButtonOnTheFormPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a student record (.*) should not be present")]
        public void ThenAStudentRecordTedShouldNotBePresent(string familyName)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
