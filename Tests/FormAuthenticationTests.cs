using Pages;

namespace Tests
{
    public class FormAuthenticationTests : BaseTestClass
    {
        [Test, Category("Form Authentication")]
        [TestCase("tomsmith", "SuperSecretPassword!")]
        [Parallelizable(ParallelScope.Children)]
        public void SuccessfulLogin(string username, string password)
        {
            FormAuthenticationPage page = homePage.goToFormAuthenticationPage();
            page.fillUsername(username);
            page.fillPassword(password);
            page.clickLoginButton();
            Assert.AreEqual("You logged into a secure area!\r\n×", page.getSuccessfulLoginAlert());
        }

        [Test, Category("Form Authentication")]
        [TestCase("tomsmithh", "SuperSecretPassword!")]
        [TestCase("", "SuperSecretPassword!")]
        [Parallelizable(ParallelScope.Children)]
        public void InvalidUsername(string username, string password)
        {
            FormAuthenticationPage page = homePage.goToFormAuthenticationPage();
            page.fillUsername(username);
            page.fillPassword(password);
            page.clickLoginButton();
            Assert.AreEqual("Your username is invalid!\r\n×", page.getInvalidUsernameAlert());
        }

        [Test, Category("Form Authentication")]
        [TestCase("tomsmith", "SuperSecretPassword")]
        [Parallelizable(ParallelScope.Children)]
        public void InvalidPassword(string username, string password)
        {
            FormAuthenticationPage page = homePage.goToFormAuthenticationPage();
            page.fillUsername(username);
            page.fillPassword(password);
            page.clickLoginButton();
            Assert.AreEqual("Your password is invalid!\r\n×", page.getInvalidPasswordAlert());
        }
    }
}
