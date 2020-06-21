using DemoQAExecise.Tests;
using DemoQAExercise.Pages.SoftuniSearchPage;
using NUnit.Framework;

namespace DemoQAExercise.Tests.SoftuniCourseSearch
{
    [TestFixture]
    public class SoftuniSearchTests : BaseTest
    {
        private SoftuniSearchPage _softuniSearchPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://softuni.bg");
            Driver.Manage().Window.Maximize();
            _softuniSearchPage = new SoftuniSearchPage(Driver);
        }

        [Test]
        public void QAAutomationCourseFound()
        {
            _softuniSearchPage.QACourseNavigationTo();

            Assert.IsTrue(_softuniSearchPage.HeadingTag.Text.Contains("QA Automation - май 2020"));
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
