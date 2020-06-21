using DemoQAExecise.Tests;
using NUnit.Framework;
using System.Threading;
using DemoQAExercise.Pages.Interaction.Selectable;

namespace DemoQAExercise.Tests.InteractionsPanel
{
    [TestFixture]
    public class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();

            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigationToPage("Selectable");
            _selectablePage.PageLoad();
        }

        [Test]
        public void Test4_1_ObjectIsSelectable_ListMenu()
        {
            _selectablePage.PageLoad();

            Thread.Sleep(500);
            Builder.Click(_selectablePage.SelectableObjectList).Release().Perform();

            var colorAfter = _selectablePage.SelectableObjectList.GetCssValue("background-color");

            _selectablePage.AssertSelectableObjectBackgroundColorChanged(colorAfter);
        }


        [Test]
        public void Test4_2_ObjectIsSelectable_GridMenu()
        {
            _selectablePage.MenuGridNavigationSelectable.Click();
            _selectablePage.PageLoad();

            //Thread.Sleep(500);
            Builder.Click(_selectablePage.SelectableObjectGrid).Release().Perform();

            var colorAfter = _selectablePage.SelectableObjectGrid.GetCssValue("background-color");

            _selectablePage.AssertSelectableObjectBackgroundColorChanged(colorAfter);
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
