using DemoQAExecise.Pages;
using DemoQAExercise.Utilities.Extensions;
using OpenQA.Selenium;

namespace DemoQAExercise.Pages
{
    public class InteractionPageSection : BasePage
    {
        public InteractionPageSection(IWebDriver driver) 
            : base(driver)
        {
        }

        public void NavigationToPage(string sectionName)
        {

            Driver.Navigate().GoToUrl("http://DemoQA.com/");
            Driver.Manage().Window.Maximize();

            var interactions = Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));
            interactions.Click();
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            IWebElement menuButton = Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));
            Driver.ScrollTo(menuButton);
            menuButton.Click();
        }
    }
}
