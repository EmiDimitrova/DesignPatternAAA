using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Droppable
{
    public partial class DroppablePage : InteractionPageSection
    {
        public IWebElement sourceBox => Wait.Until(d => d.FindElement(By.Id("draggable")));

        public IWebElement targetBox => Wait.Until(d => d.FindElement(By.Id("droppable")));

        public IWebElement messageText => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"droppable\"]/p")));
    }
}
