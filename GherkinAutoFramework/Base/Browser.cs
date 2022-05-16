namespace GherkinAutoFramework.Base
{
    public class Browser
    {
        private readonly ParallelConfig _parallelConfig;

        public Browser(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            _parallelConfig.Driver.Url = url;
        }
    }

    public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
}