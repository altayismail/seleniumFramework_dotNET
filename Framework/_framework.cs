using Framework.Logging;
using NUnit.Framework;

namespace Framework
{
    public static class _framework
    {
        public static string testResultDirectory = Path.GetFullPath(@"../../../../");
        public static MyLogger Log => _logger ?? throw new NullReferenceException("Logger is null, first set logger");

        [ThreadStatic]
        public static DirectoryInfo? CurrentTestDirectory;
        [ThreadStatic]
        private static MyLogger? _logger;
        public static DirectoryInfo CreateTestResultDirectory()
        {
            var testDirectory = testResultDirectory + "TestResults";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory, true);
            }

            return Directory.CreateDirectory(testDirectory);
        }

        public static void SetLogger()
        {
            var testResultDirect = testResultDirectory + "TestResults";
            var testName = TestContext.CurrentContext.Test.Name;
            var fullPath = $"{testResultDirect}\\{testName}";

            if (Directory.Exists(fullPath))
            {
                CurrentTestDirectory = Directory.CreateDirectory(fullPath + TestContext.CurrentContext.Test.ID);
            }
            else
            {
                CurrentTestDirectory = Directory.CreateDirectory(fullPath);
            }

            _logger = new MyLogger(testName, CurrentTestDirectory.FullName + "/Logs.txt");
        }
    }
}
