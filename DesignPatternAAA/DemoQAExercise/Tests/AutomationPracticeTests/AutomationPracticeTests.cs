using DemoQAExecise.Tests;
using NUnit.Framework;
using OldHomeworks.Factories;
using OldHomeworks.Models;
using OldHomeworks.Pages.AutomationPracticePage;
using OpenQA.Selenium;

namespace OldHomeworks.Tests.AutomationPracticeTests
{
    [TestFixture]
    public class AutomationPracticeTests : BaseTest
    {
        private AutomationPracticePage _automationPracticePage;
        private AutomationPracticeModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.Manage().Window.Maximize();  
            _automationPracticePage = new AutomationPracticePage(Driver);
            _user = AutomationPracticeFactory.Create();
            
            _automationPracticePage.SignInButton.Click();

            _automationPracticePage.EmailInput.SendKeys($"{_automationPracticePage.RandomEmail()}" + Keys.Enter);
        }

        [Test]
        public void NavigatedToRegisterForm()
        {
            _automationPracticePage.AssertRegisterFormOpened();
        }

        [Test]
        public void ErrorMessageDisplayed_When_FillFormWithoutFirstName()
        {
            _user.FirstName = string.Empty;

            _automationPracticePage.FillFormAndRegisterButtonClick(_user);

            _automationPracticePage.AssertErrorMissingFirstName();
        }

        [Test]
        public void ErrorMessageDisplayed_When_FillFormWithoutLastName()
        {
            _user.LastName = string.Empty;

            _automationPracticePage.FillFormAndRegisterButtonClick(_user);

            _automationPracticePage.AssertErrorMissingLastName();
        }

        [Test]
        public void ErrorMessageDisplayed_When_FillFormWithoutPhoneNumber()
        {
            _user.PhoneNumber = string.Empty;

            _automationPracticePage.FillFormAndRegisterButtonClick(_user);

            _automationPracticePage.AssertErrorMissingPhoneNumber();
        }

        [Test]
        public void ErrorMessageDisplayed_When_FillFormWithoutPassword()
        {
            _user.Password = string.Empty;

            _automationPracticePage.FillFormAndRegisterButtonClick(_user);

            _automationPracticePage.AssertErrorMissingPassword();
        }

        [Test]
        public void ErrorMessageDisplayed_When_FillFormWithoutAddress()
        {
            _user.Address = string.Empty;

            _automationPracticePage.FillFormAndRegisterButtonClick(_user);

            _automationPracticePage.AssertErrorMissingAddress();
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
