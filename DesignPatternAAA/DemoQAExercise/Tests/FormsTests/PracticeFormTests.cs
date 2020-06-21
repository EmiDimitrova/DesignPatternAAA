using DemoQAExecise.Factories;
using DemoQAExecise.Models;
using DemoQAExecise.Pages.PracticeForm;
using NUnit.Framework;

namespace DemoQAExecise.Tests.Forms
{
    [TestFixture]
    public class PracticeFormTests : BaseTest
    {
        private PracticeFormPage _practiceFormPage;
        private PracticeFormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://DemoQA.com/automation-practice-form");
            _practiceFormPage = new PracticeFormPage(Driver);
            _user = PracticeFormFactory.Create();
        }

        [Test]
        public void ThanksMessageDisplayed_When_FillFormWithValidData()
        {
            _practiceFormPage.FillForm(_user);

            var actualMessage = _practiceFormPage.Popup.Message.Text;
            Assert.AreEqual("Thanks for submitting the form", actualMessage);
        }

        [Test]
        public void ErrorMessageDisplayed_When_FillFormWithoutFirstName()
        {
            _user.FirstName = string.Empty;
            _practiceFormPage.FillForm(_user);
            _practiceFormPage.PageLoad();
            _practiceFormPage.AssertErrorBorderColor(_practiceFormPage.FirstName);
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
