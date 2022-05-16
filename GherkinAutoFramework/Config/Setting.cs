using GherkinAutoFramework.Base;

namespace GherkinAutoFramework.Config
{
    public class Settings
    {
        public static string AUT { get; set; }

        public static string BuildName { get; set; }

        public static BrowserType BrowserType { get; set; }

        public static string OutputPath { get; set; }

        private static bool _fileCreated = false;

        public static bool FileCreated
        {
            get
            {
                return _fileCreated;
            }
            set
            {
                _fileCreated = value;
            }
        }
    }
}