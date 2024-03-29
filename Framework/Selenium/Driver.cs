﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Selenium
{
    public static class Driver
    {
        [ThreadStatic]
        private static IWebDriver _driver;
        [ThreadStatic]
        private static WebDriverWait _wait;

        public static void Init(string browserName)
        {
            _driver = DriverFactory.setBrowser(browserName);
            _wait = new WebDriverWait(CurrentDriver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
        }

        public static IWebDriver CurrentDriver => _driver ?? throw new NullReferenceException("Driver is null!!");
        public static WebDriverWait CurrentWait => _wait ?? throw new NullReferenceException("WebDriverWait is null!!");
        public static void Goto(string url)
        {
            if (!url.StartsWith("https://"))
                url = "https://{url}";

            _framework.Log.Info($"URL: {url}");
            _driver.Navigate().GoToUrl(url);
        }

        public static void TakeScreenShot(string imageName)
        {
            var screenShot = ((ITakesScreenshot)(CurrentDriver)).GetScreenshot();
            var ssFileName = Path.Combine(_framework.CurrentTestDirectory.FullName, imageName);
            screenShot.SaveAsFile($"{ssFileName}.png", ScreenshotImageFormat.Png);
        }

        public static void Quit()
        {
            _framework.Log.Info("Closing Browser\n__________________________________________________________");
            CurrentDriver.Quit();
        }
    }
}
