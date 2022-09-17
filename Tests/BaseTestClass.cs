using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;

namespace Tests
{
    public class BaseTestClass
    {
        IWebDriver _driver;
        protected HomePage homePage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://the-internet.herokuapp.com";
            homePage = new HomePage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
