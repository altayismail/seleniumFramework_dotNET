using Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class HomePage
    {
        IWebDriver _driver;
        WebDriverWait _wait;
        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;       
            _wait = wait;
        }

        private By FormAuthentication = By.LinkText("Form Authentication");
        private By DynamicControls = By.LinkText("Dynamic Controls");

        public FormAuthenticationPage goToFormAuthenticationPage()
        {
            _framework.Log.Step("Going to the Form Authentication Page.");
            _driver.FindElement(FormAuthentication).Click();
            return new FormAuthenticationPage(_driver);
        }

        public DynamicControlsPage goToDynamicControlsPage()
        {
            _framework.Log.Step("Going to the Dynamic Controls Page");
            _driver.FindElement(DynamicControls).Click();
            return new DynamicControlsPage(_driver, _wait);
        }
    }
}
