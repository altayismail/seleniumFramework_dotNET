using Framework.Selenium;
using Pages;

namespace Tests
{
    public class BaseTestClass
    {
        protected HomePage homePage;

        [SetUp]
        public void Setup()
        {
            Driver.Init();
            Driver.CurrentDriver.Manage().Window.Maximize();
            Driver.CurrentDriver.Url = "https://the-internet.herokuapp.com";
            homePage = new HomePage(Driver.CurrentDriver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CurrentDriver.Quit();
        }
    }
}
