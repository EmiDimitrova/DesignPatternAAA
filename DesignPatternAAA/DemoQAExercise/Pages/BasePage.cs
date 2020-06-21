using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoQAExecise.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true)", element);
            return element;
        }

        public void PageLoad()
        {
            Wait.Until(Driver => ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
