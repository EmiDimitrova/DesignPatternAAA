using DemoQAExecise.Tests;
using DemoQAExercise.Factories;
using DemoQAExercise.Models;
using DemoQAExercise.Pages.GoogleSearchPage;
using NUnit.Framework;

namespace DemoQAExercise.Tests.GoogleSearchTests
{
    [TestFixture]
    public class GoogleSearchTests : BaseTest
    {
        private GoogleSearchPage _googleSearchPage;
        private GoogleSearchModel _word;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://google.com");
            _googleSearchPage = new GoogleSearchPage(Driver);
            _word = GoogleSearchFactory.Create();
        }

        [Test]
        public void FirstResultLinkCheckIfTitleTrue()
        {
            _googleSearchPage.SearchInGoogle(_word);

            _googleSearchPage.FirstResultLink.Click();

            _googleSearchPage.AssertWebsiteTitleIsCorrect();
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }

    
}
