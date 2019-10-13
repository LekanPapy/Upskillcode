using CourseManagementUITestAutomation.Hooks;
using System;
using System.Collections.Generic;
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
            context.ShutDownCMSApplication();
        }

    }
}
