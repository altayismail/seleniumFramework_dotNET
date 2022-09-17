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

        public FormAuthenticationPage goToFormAuthenticationPage()
        {
            _driver.FindElement(FormAuthentication).Click();
            return new FormAuthenticationPage(_driver);
        }
    }
}
