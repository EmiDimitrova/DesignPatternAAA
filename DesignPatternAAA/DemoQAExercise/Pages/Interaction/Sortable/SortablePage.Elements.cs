using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace DemoQAExercise.Pages.Interaction.Sortable
{
    public partial class SortablePage : InteractionPageSection
    {

        public List<IWebElement> listOfOptionsList => Wait.Until(d => d.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList());

        public IWebElement menuGridNavigationSortable => Wait.Until(d => d.FindElement(By.XPath("//*[normalize-space(text())='Grid']")));

        public IWebElement sortableSourceObjectGrid => Wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'create-grid')]//*[normalize-space(text())='One']")));

        public IWebElement sortableTargetObjectGrid => Wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'create-grid')]//*[normalize-space(text())='Nine']")));

        public IWebElement sortableObjectGridPosition => Wait.Until(d => d.FindElement(By.XPath("//div[contains(@class, 'create-grid')]//*")));
    }
}
