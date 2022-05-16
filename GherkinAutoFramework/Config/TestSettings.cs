using GherkinAutoFramework.Base;
using Newtonsoft.Json;

namespace GherkinAutoFramework.Config
{
    [JsonObject("testSettings")]
    public class TestSettings
    {
        [JsonProperty("aut")]
        public string AUT { get; set; }

        [JsonProperty("browser")]
        public BrowserType Browser { get; set; }

        [JsonProperty("outputPath")]
        public string OutputPath { get; set; }
    }
}