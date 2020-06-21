using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Draggable
{
    public partial class DraggablePage : InteractionPageSection
    {
        public IWebElement DragableObject => Wait.Until(d => d.FindElement(By.Id("dragBox")));
    }
}
