using Framework;
using OpenQA.Selenium;

namespace Pages
{
    public class HomePage
    {
        IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;       
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
            return new DynamicControlsPage(_driver);
        }
    }
}
