using Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class DynamicControlsPage
    {
        IWebDriver _driver;
        WebDriverWait _wait;
        public DynamicControlsPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By CheckBox = By.CssSelector("#checkbox");
        private By RemoveButton = By.XPath("//button[contains(text(),'Remove')]");
        private By ItIsGoneMessage = By.XPath("//p[@id='message']");
        private By ItIsBack = By.XPath("//p[@id='message']");
        private By AddButton = By.XPath("//button[contains(text(),'Add')]");

        public void clickRemoveButton()
        {
            _framework.Log.Step("Clicking Remove Button");
            _driver.FindElement(RemoveButton).Click();
            _wait.Until(el => el.FindElement(ItIsGoneMessage));
        }

        public string getItIsGoneMessage()
        {
            _framework.Log.Step("Getting It is gone message");
            return _driver.FindElement(ItIsGoneMessage).Text;
        }

        public string getItIsBackMessage()
        {
            _framework.Log.Step("Getting It is back message");
            return _driver.FindElement(ItIsBack).Text;
        }

        public void clickAddButton()
        {
            _framework.Log.Step("Clicking Add Button");
            _driver.FindElement(AddButton).Click();
            _wait.Until(el => el.FindElement(ItIsBack));
        }
    }
}
