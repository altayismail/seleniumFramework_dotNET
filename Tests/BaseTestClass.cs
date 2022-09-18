using Framework.Selenium;
using Pages;
using Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    public class BaseTestClass
    {
        protected HomePage homePage;

        [OneTimeSetUp]
        public void BeforeAll()
        {
            _framework.SetConfig();
            _framework.CreateTestResultDirectory();
            _framework.SetLogger();
        }

        [SetUp]
        public void Setup()
        {
            Driver.Init(_framework.Config.Driver.Browser);
            Driver.Goto(_framework.Config.Test.URL);
            homePage = new HomePage(Driver.CurrentDriver, Driver.CurrentWait);
        }

        [TearDown]
        public void TearDown()
        {
            var outcome = TestContext.CurrentContext.Result.Outcome.Status;

            if (outcome == TestStatus.Passed)
            {
                Driver.TakeScreenShot(TestContext.CurrentContext.Test.MethodName);
                _framework.Log.Info("Outcome: Passed");
            }
            else if (outcome == TestStatus.Failed)
            {
                Driver.TakeScreenShot(TestContext.CurrentContext.Test.MethodName);
                _framework.Log.Info("Outcome: Failed");
            }
            else
                _framework.Log.Warning("Outcome: " + outcome);

            Driver.Quit();
        }
    }
}
