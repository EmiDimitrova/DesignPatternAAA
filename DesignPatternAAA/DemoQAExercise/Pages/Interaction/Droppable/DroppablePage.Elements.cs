using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Droppable
{
    public partial class DroppablePage : InteractionPageSection
    {
        public IWebElement SourceBox => Wait.Until(d => d.FindElement(By.Id("draggable")));

        public IWebElement TargetBox => Wait.Until(d => d.FindElement(By.Id("droppable")));

        public IWebElement MessageText => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"droppable\"]/p")));
    }
}
