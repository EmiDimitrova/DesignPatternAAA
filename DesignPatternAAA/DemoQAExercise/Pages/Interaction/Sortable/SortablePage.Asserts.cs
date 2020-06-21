using NUnit.Framework;

namespace DemoQAExercise.Pages.Interaction.Sortable
{
    public partial class SortablePage : InteractionPageSection
    {

        public void AssertSortableObjectPositionIsChangedGrid(string txt)
        {
            Assert.AreEqual("Two", SortableObjectGridPosition.Text);
        }

        public void AssertSortableObjectPositionIsChanged(int index)
        {
            Assert.AreEqual("Two", ListOfOptionsList[index + 1].Text);
        }
    }
}
