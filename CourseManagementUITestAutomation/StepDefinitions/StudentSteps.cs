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
        Context context;
        StudentPage studentPage;

        public StudentSteps(Context _context, StudentPage _studentPage)
        {
            context = _context;
            studentPage = _studentPage;
        }

        [Given(@"that CMS application is loaded")]
        public void GivenThatCMSApplicationIsLoaded()
        {
            context.LoadCMSApplication();
        }

        [When(@"a user clicks on Students link")]
        public void WhenAUserClicksOnStudentsLink()
        {
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

        [AfterScenario]
        public void CloseAUT()
        {
            context.ShutDownCMSApplication();
        }

    }
}
