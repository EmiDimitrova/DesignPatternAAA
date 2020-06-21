using DemoQAExecise.Tests;
using NUnit.Framework;
using System.Threading;
using DemoQAExercise.Pages.Interaction.Droppable;

namespace DemoQAExercise.Tests.InteractionsPanel
{
    [TestFixture]
    public class Droppable : BaseTest
    {
        private DroppablePage _droppblePage;

        [SetUp]
        public void Setup()
        {
            Initialize();

            _droppblePage = new DroppablePage(Driver);
            _droppblePage.NavigationToPage("Droppable");
            _droppblePage.PageLoad();
        }

        [Test]
        public void Test2_1_DragAndDropToTheCenterOfDropArea()
        {
            var colorBefore = _droppblePage.TargetBox.GetCssValue("background-color");

            Thread.Sleep(500);
            Builder.DragAndDrop(_droppblePage.SourceBox, _droppblePage.TargetBox).Perform();

            var colorAfter = _droppblePage.TargetBox.GetCssValue("background-color");

            _droppblePage.AssertDroppableTargetBoxColorIsChanged(colorBefore, colorAfter);
        }


        [Test]
        public void Test2_2_DragAndDropToTheDownLeftCornerOfDropAreaStillNotDropped()
        {
            var colorBefore = _droppblePage.TargetBox.GetCssValue("background-color");

            Thread.Sleep(500);
            Builder.DragAndDropToOffset(_droppblePage.SourceBox, 224, 102).Perform();

            var colorAfter = _droppblePage.TargetBox.GetCssValue("background-color");

            _droppblePage.AssertDroppableTargetBoxColorIsNOTChanged(colorBefore, colorAfter);
        }

        [Test]
        public void Test2_3_DragAndDropMessageCheck()
        {
            _droppblePage.AssertDroppableSourceBoxTextCheck("Drop here");

            Thread.Sleep(500);
            Builder.DragAndDrop(_droppblePage.SourceBox, _droppblePage.TargetBox).Perform();

            _droppblePage.AssertDroppableSourceBoxTextIsChanged("Dropped!");
        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
