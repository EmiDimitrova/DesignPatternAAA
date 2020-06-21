using NUnit.Framework;

namespace DemoQAExercise.Pages.Interaction.Draggable
{
    public partial class DraggablePage : InteractionPageSection
    {
        public void AssertDraggablePositionIsChanged(int sourcePositionXBefore, int sourcePositionXAfter)
        {
            Assert.AreNotEqual(sourcePositionXBefore, sourcePositionXAfter);
        }

        public void AssertDraggableMovedToTopLeftCorner(int sourcePositionXAfter)
        {
            Assert.AreEqual(160, sourcePositionXAfter, 5);
        }

        public void AssertDraggableMovedToBottom(int sourcePositionYAfter)
        {
            Assert.AreEqual(650, sourcePositionYAfter, 5);
        }
    }
}
