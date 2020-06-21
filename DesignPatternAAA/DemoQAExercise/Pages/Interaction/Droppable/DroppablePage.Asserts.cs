using NUnit.Framework;

namespace DemoQAExercise.Pages.Interaction.Droppable
{
    public partial class DroppablePage : InteractionPageSection
    {
        public void AssertDroppableTargetBoxColorIsChanged(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertDroppableTargetBoxColorIsNOTChanged(string colorBefore, string colorAfter)
        {
            Assert.AreEqual(colorBefore, colorAfter);
        }


        public void AssertDroppableSourceBoxTextCheck(string message)
        {
            Assert.AreEqual("Drop here", messageText.Text);
        }

        public void AssertDroppableSourceBoxTextIsChanged(string message)
        {
            Assert.AreEqual("Dropped!", messageText.Text);
        }
    }
}
