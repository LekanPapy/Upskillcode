using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementUITestAutomation.Hooks;
using OpenQA.Selenium;
using System.Threading;

namespace CourseManagementUITestAutomation.Pages
{
    public class StudentPage
    {      
        //We will use constructor dependency injection to create an object of context class
        Context context;

        public StudentPage(Context _context)
        {
            context = _context;
        }

        By studentLink = By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[1]/a");
        By createNewLink = By.XPath("/html/body/div[2]/p/a");
        By familyName = By.Id("LastName");
        By firstName = By.Id("FirstName");
        By enrollmentDate = By.Id("EnrollmentDate");
        By studentCreateButton = By.XPath("/html/body/div[2]/form/div/div[5]/div/input");

        public void ClickOnStudentLink()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(studentLink).Click();
        }

        public void ClickOnCreateNewLink()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(createNewLink).Click();
        }

        public void FillInFamilyName(string familyNameData)
        {
            Thread.Sleep(1000);
            IWebElement familyNameField = context.driver.FindElement(familyName);
            familyNameField.Clear();
            familyNameField.SendKeys(familyNameData);
        }

        public void FillInFirstName(string firstNameData)
        {
            Thread.Sleep(1000);
            IWebElement firstNameField = context.driver.FindElement(firstName);
            firstNameField.Clear();
            firstNameField.SendKeys(firstNameData);
        }

        public void FillInEnrollmentDate(string enrollmentDateData)
        {
            Thread.Sleep(1000);
            IWebElement enrollmentDateField = context.driver.FindElement(enrollmentDate);
            enrollmentDateField.Clear();
            enrollmentDateField.SendKeys(enrollmentDateData);
        }

        public void ClickOnCreateButton()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(studentCreateButton).Click();
        }

        public string VerifyStudentRecordCreation()
        {
            return context.driver.Url;
        }
    }
}
