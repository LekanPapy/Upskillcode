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
        By familyNameErrorMessage = By.XPath("/html/body/div[2]/form/div/div[2]/div/span");
        By firstNameErrorMessage = By.XPath("/html/body/div[2]/form/div/div[3]/div/span");
        By enrollmentDateErrorMessage = By.XPath("/html/body/div[2]/form/div/div[4]/div/span");
        By editLink = By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[4]/a[1]");
        By saveButton = By.XPath("/html/body/div[2]/form/div/div[4]/div/input");
        By deleteLink = By.XPath("/html/body/div[2]/table/tbody/tr[2]/td[4]/a[3]");
        By deleteButton = By.XPath("/html/body/div[2]/div/form/div/input");

        public void ClickOnStudentLink()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(studentLink,30).Click();
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

        public string ReturnFamilyNameErrorMessage()
        {
            return context.driver.FindElement(familyNameErrorMessage).Text.Trim();
        }

        public string ReturnFirstNameErrorMessage()
        {
            return context.driver.FindElement(firstNameErrorMessage).Text.Trim();
        }

        public string ReturnEnrollmentDateErrorMessage()
        {
            return context.driver.FindElement(enrollmentDateErrorMessage).Text.Trim();        
        }

        public void ClickOnEditButton()
        {
            context.driver.Navigate().Refresh();
            Thread.Sleep(1000);
            context.driver.FindElement(editLink).Click();
            Thread.Sleep(1000);
        }

        public void ClickOnSaveButton()
        {
            context.driver.FindElement(saveButton).Click();
            Thread.Sleep(1000);
        }

        public void ClickOnDeleteLink()
        {
            context.driver.Navigate().Refresh();
            Thread.Sleep(1000);
            context.driver.FindElement(deleteLink).Click();
            Thread.Sleep(1000);
        }

        public void ClickOnDeleteButton()
        {
            context.driver.FindElement(deleteButton).Click();
            Thread.Sleep(1000);
        }
    }
}
