using DemoQAExecise.Pages;
using DemoQAExercise.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQAExercise.Pages.GoogleSearchPage
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement SearchField => Wait.Until(d => d.FindElement(By.CssSelector("#tsf > div:nth-child(2) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input")));

        public IWebElement FirstResultLink => Wait.Until(d => d.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a")));

        public void SearchInGoogle(GoogleSearchModel word)
        {
            SearchField.SendKeys(word.SearchField);
            SearchField.SendKeys(Keys.Enter);
        }

        public void AssertWebsiteTitleIsCorrect()
        {
            Assert.AreEqual("SeleniumHQ Browser Automation", Driver.Title);
        }
    }
}
