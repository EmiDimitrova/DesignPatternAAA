using DemoQAExecise.Tests;
using NUnit.Framework;
using System.Threading;
using DemoQAExercise.Pages.Interaction.Sortable;

namespace DemoQAExercise.Tests.InteractionsPanel
{
    [TestFixture]
    public class Sortable : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();

            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigationToPage("Sortable");
            _sortablePage.PageLoad();
        }

        [Test]
        public void Test5_1_ObjectIsSortable_GridMenu()
        {
            _sortablePage.MenuGridNavigationSortable.Click();

            Thread.Sleep(1000);
            Builder.ClickAndHold(_sortablePage.SortableSourceObjectGrid).MoveToElement(_sortablePage.SortableTargetObjectGrid).Release().Perform();

            _sortablePage.AssertSortableObjectPositionIsChangedGrid(_sortablePage.SortableObjectGridPosition.Text);
        }

        [Test]
        public void Test5_2_ObjectIsSortable_ListMenu()
        {
            var index = 1;

            Thread.Sleep(1000);
            Builder.DragAndDropToOffset(_sortablePage.ListOfOptionsList[index], 0, 50).Perform();

            _sortablePage.AssertSortableObjectPositionIsChanged(index);
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
