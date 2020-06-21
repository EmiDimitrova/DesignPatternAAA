using NUnit.Framework;

namespace DemoQAExercise.Pages.Interaction.Resizable
{
    public partial class ResizablePage : InteractionPageSection
    {
        public void AssertResizableHandlePositionToMinimum()
        {
            Assert.AreEqual(550, ResizableHandle.Location.X, 5);
        }

        public void AssertResizableHandlePositionToMaximum()
        {
            Assert.AreEqual(900, ResizableHandle.Location.X, 5);
        }
    }
}
