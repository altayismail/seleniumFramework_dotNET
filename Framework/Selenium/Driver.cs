using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Selenium
{
    public static class Driver
    {
        private static IWebDriver _driver;

        public static void Init()
        {
            _driver = new ChromeDriver();
        }

        public static IWebDriver CurrentDriver => _driver ?? throw new NullReferenceException("Driver is null!!");
    }
}
