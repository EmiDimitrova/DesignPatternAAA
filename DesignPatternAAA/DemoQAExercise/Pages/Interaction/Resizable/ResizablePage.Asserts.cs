using NUnit.Framework;

namespace DemoQAExercise.Pages.Interaction.Resizable
{
    public partial class ResizablePage : InteractionPageSection
    {
        public void AssertResizableHandlePositionToMinimum(int x)
        {
            Assert.AreEqual(550, resizableHandle.Location.X, 5);
        }

        public void AssertResizableHandlePositionToMaximum(int x)
        {
            Assert.AreEqual(900, resizableHandle.Location.X, 5);
        }
    }
}
