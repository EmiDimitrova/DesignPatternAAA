using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Resizable
{
    public partial class ResizablePage : InteractionPageSection
    {
        public IWebElement ResizableHandle => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div/span")));

    }
}
