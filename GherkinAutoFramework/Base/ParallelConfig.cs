using AventStack.ExtentReports;
using NLog;
using OpenQA.Selenium;

namespace GherkinAutoFramework.Base
{
    public class ParallelConfig
    {
        public IWebDriver Driver { get; set; }

        public BasePage CurrentPage { get; set; }

        public Logger Log { get; set; }

        public MediaEntityModelProvider CaptureScreenshotAndReturnModel(string Name)
        {
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();
        }
    }
}