using NUnit.Framework;

namespace DemoQAExercise.Pages.Interaction.Selectable
{
    public partial class SelectablePage : InteractionPageSection
    {
        public void AssertSelectableObjectBackgroundColorChanged(string colorAfter)
        {
            Assert.AreEqual("rgba(0, 123, 255, 1)", colorAfter);
        }
    }
}
