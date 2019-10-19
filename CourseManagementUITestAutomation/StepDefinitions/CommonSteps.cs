using CourseManagementUITestAutomation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CourseManagementUITestAutomation.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        Context context;

        public CommonSteps(Context _context)
        {
            context = _context;
        }

        [Given(@"that CMS application is loaded")]
        public void GivenThatCMSApplicationIsLoaded()
        {
            context.LoadCMSApplication();
        }

        [AfterScenario]
        public void CloseAUT()
        {
            if (ScenarioContext.Current.TestError != null)  //this condition will always be true when a test fails
            {
                string scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
                string directory = Directory.GetCurrentDirectory() + @"\Screenshots\";
                TakeScreenshotAtThePointOfTestFailure(directory, scenarioName);
            }
            context.ShutDownCMSApplication();
        }

        public void TakeScreenshotAtThePointOfTestFailure(string directory, string scenarioName)
        {
            Screenshot screenshot = ((ITakesScreenshot)context.driver).GetScreenshot();
            string path = directory + scenarioName + DateTime.Now.ToString("yyyy-MM-dd") + ".png";
            string Screenshot = screenshot.AsBase64EncodedString;
            byte[] screenshotAsByteArray = screenshot.AsByteArray;
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
        }

    }
}
