using Pages;

namespace Tests
{
    public class DynamicControlsTests : BaseTestClass
    {
        [Test, Category("Dynamic Control")]
        public void confirmItIsGoneMessage()
        {
            DynamicControlsPage page = homePage.goToDynamicControlsPage();
            page.clickRemoveButton();
            Assert.AreEqual("It's gone!", page.getItIsGoneMessage());
        }

        [Test, Category("Dynamic Control")]
        public void confirmItIsBackMessage()
        {
            DynamicControlsPage page = homePage.goToDynamicControlsPage();
            page.clickRemoveButton();
            page.clickAddButton();
            Assert.AreEqual("It's back!", page.getItIsBackMessage());
        }
    }
}
