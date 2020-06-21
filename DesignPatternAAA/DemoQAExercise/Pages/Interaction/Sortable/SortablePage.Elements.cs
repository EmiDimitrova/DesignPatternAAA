using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace DemoQAExercise.Pages.Interaction.Sortable
{
    public partial class SortablePage : InteractionPageSection
    {

        public List<IWebElement> ListOfOptionsList => Wait.Until(d => d.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList());

        public IWebElement MenuGridNavigationSortable => Wait.Until(d => d.FindElement(By.XPath("//*[normalize-space(text())='Grid']")));

        public IWebElement SortableSourceObjectGrid => Wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'create-grid')]//*[normalize-space(text())='One']")));

        public IWebElement SortableTargetObjectGrid => Wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'create-grid')]//*[normalize-space(text())='Nine']")));

        public IWebElement SortableObjectGridPosition => Wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'create-grid')]//*")));
    }
}
