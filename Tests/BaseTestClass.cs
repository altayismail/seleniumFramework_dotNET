using Framework.Selenium;
using Pages;
using Framework;

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
            homePage = new HomePage(Driver.CurrentDriver);
        }

        [TearDown]
        public void TearDown()
        {
            _framework.Log.Info("Closing Browser\n__________________________________________________________");
            Driver.CurrentDriver.Quit();
        }
    }
}
