using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Selenium
{
    public static class DriverFactory
    {
        public static IWebDriver setBrowser(string browserName)
        {
            _framework.Log.Info("Browser: Chrome");
            switch (browserName)
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                default:
                    throw new ArgumentException($"{browserName} is not supported.");
            }
        }
    }
}
