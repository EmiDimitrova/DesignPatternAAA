using OpenQA.Selenium;

namespace DemoQAExercise.Pages.Interaction.Selectable
{
    public partial class SelectablePage : InteractionPageSection
    {
        public IWebElement selectableObjectList => Wait.Until(d => d.FindElement(By.XPath("//*[normalize-space(text())='Cras justo odio']")));

        public IWebElement menuGridNavigationSelectable => Wait.Until(d => d.FindElement(By.Id("demo-tab-grid")));

        public IWebElement selectableObjectGrid => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"row1\"]/li[1]")));

    }
}
