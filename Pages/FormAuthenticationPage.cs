using OpenQA.Selenium;

namespace Pages
{
    public class FormAuthenticationPage
    {
        IWebDriver _driver;

        public FormAuthenticationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By UsernameField = By.CssSelector("#username");
        private By PasswordField = By.CssSelector("#password");
        private By LoginButton = By.TagName("i");
        private By SuccessfulLoginAlert = By.CssSelector("#flash");
        private By InvalidPasswordAlert = By.CssSelector("#flash");
        private By InvalidUsernameAlert = By.CssSelector("#flash");

        public void fillUsername(string username)
        {
            _driver.FindElement(UsernameField).SendKeys(username);
        }

        public void fillPassword(string password)
        {
            _driver.FindElement(PasswordField).SendKeys(password);
        }

        public void clickLoginButton()
        {
            _driver.FindElement(LoginButton).Click();
        }

        public string getSuccessfulLoginAlert()
        {
            return _driver.FindElement(SuccessfulLoginAlert).Text;
        }

        public string getInvalidUsernameAlert()
        {
            return _driver.FindElement(InvalidUsernameAlert).Text;
        }

        public string getInvalidPasswordAlert()
        {
            return _driver.FindElement(InvalidPasswordAlert).Text;
        }
    }
}
