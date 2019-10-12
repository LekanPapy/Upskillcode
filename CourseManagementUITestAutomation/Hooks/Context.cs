using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace CourseManagementUITestAutomation.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        string baseUrl = "http://localhost/CourseManagementSystem";

        public void LoadCMSApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            Thread.Sleep(2000);
        }

        public void ShutDownCMSApplication()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
