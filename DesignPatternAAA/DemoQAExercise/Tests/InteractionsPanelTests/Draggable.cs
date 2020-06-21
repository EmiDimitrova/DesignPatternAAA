using DemoQAExecise.Tests;
using NUnit.Framework;
using System.Threading;
using DemoQAExercise.Pages.Interaction.Draggable;

namespace DemoQAExercise.Tests.InteractionsPanel
{
    [TestFixture]
    public class Draggable : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigationToPage("Dragabble");
            _draggablePage.PageLoad();
        }

        [Test]
        public void Test1_1_ObjectIsDragable()
        {
            var sourcePositionXBefore = _draggablePage.dragableObject.Location.X;

            Thread.Sleep(500);
            Builder.DragAndDropToOffset(_draggablePage.dragableObject, 224, 102).Release().Perform();

            var sourcePositionXAfter = _draggablePage.dragableObject.Location.X;

            _draggablePage.AssertDraggablePositionIsChanged(sourcePositionXBefore, sourcePositionXAfter);
        }

        [Test]
        public void Test1_2_MoveDraggableToLeftTopCorner()
        {
            Thread.Sleep(500);
            Builder.DragAndDropToOffset(_draggablePage.dragableObject, -273, -313).Release(_draggablePage.dragableObject).Perform();

            var sourcePositionXAfter = _draggablePage.dragableObject.Location.X;

            _draggablePage.AssertDraggableMovedToTopLeftCorner(sourcePositionXAfter);
        }

        [Test]
        public void Test1_3_MoveDraggableToBottom()
        {
            Thread.Sleep(500);
            Builder.DragAndDropToOffset(_draggablePage.dragableObject, 275, 355).Release(_draggablePage.dragableObject).Perform();

            var sourcePositionYAfter = _draggablePage.dragableObject.Location.Y;

            _draggablePage.AssertDraggableMovedToBottom(sourcePositionYAfter);

        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
