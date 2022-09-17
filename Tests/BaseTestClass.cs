using Framework.Selenium;
using Pages;
using Framework;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Tests
{
    public class BaseTestClass
    {
        protected HomePage homePage;

        [OneTimeSetUp]
        public void BeforeAll()
        {
            _framework.CreateTestResultDirectory();
            _framework.SetLogger();
        }

        [SetUp]
        public void Setup()
        {
            Driver.Init("chrome");
            Driver.Goto("https://the-internet.herokuapp.com");
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
