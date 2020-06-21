using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Draggable
{
    public partial class DraggablePage : InteractionPageSection
    {
        public IWebElement dragableObject => Wait.Until(d => d.FindElement(By.Id("dragBox")));
    }
}
