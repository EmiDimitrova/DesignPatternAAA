using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Selectable
{
    public partial class SelectablePage : InteractionPageSection
    {
        public IWebElement SelectableObjectList => Wait.Until(d => d.FindElement(By.XPath("//*[normalize-space(text())='Cras justo odio']")));

        public IWebElement MenuGridNavigationSelectable => Wait.Until(d => d.FindElement(By.Id("demo-tab-grid")));

        public IWebElement SelectableObjectGrid => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"row1\"]/li[1]")));

    }
}
