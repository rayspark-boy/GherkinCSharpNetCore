using NLog.Web;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;

namespace GherkinAutoFramework.Base
{
    public class TestInitializeHook : Steps
    {
        private readonly ParallelConfig _parallelConfig;

        public TestInitializeHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public void InitialLogger()
        {
            _parallelConfig.Log = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger().WithProperty("Date", string.Format("{0:yyyymmddhhmmss}", DateTime.Now));
        }

        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    _parallelConfig.Driver = new InternetExplorerDriver();
                    break;

                case BrowserType.FireFox:
                    _parallelConfig.Driver = new FirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    _parallelConfig.Driver = new ChromeDriver();
                    break;

                default:
                    break;
            }
        }
    }
}