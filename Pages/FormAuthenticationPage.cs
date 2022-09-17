using Framework;
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
            _framework.Log.Step($"Filling username: {username}");
            _driver.FindElement(UsernameField).SendKeys(username);
        }

        public void fillPassword(string password)
        {
            _framework.Log.Step($"Filling password: {password}");
            _driver.FindElement(PasswordField).SendKeys(password);
        }

        public void clickLoginButton()
        {
            _framework.Log.Step($"Clicking button.");
            _driver.FindElement(LoginButton).Click();
        }

        public string getSuccessfulLoginAlert()
        {
            _framework.Log.Step($"Getting successfull login alert.");
            return _driver.FindElement(SuccessfulLoginAlert).Text;
        }

        public string getInvalidUsernameAlert()
        {
            _framework.Log.Step($"Getting invalid username alert.");
            return _driver.FindElement(InvalidUsernameAlert).Text;
        }

        public string getInvalidPasswordAlert()
        {
            _framework.Log.Step($"Getting invalid password alert.");
            return _driver.FindElement(InvalidPasswordAlert).Text;
        }
    }
}
