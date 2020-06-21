using DemoQAExecise.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoQAExercise.Pages.SoftuniSearchPage
{
    public class SoftuniSearchPage : BasePage
    {
        public SoftuniSearchPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement UserNavigationSectionMenuObuchenia => Wait.Until(d => d.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(2) > a > span")));

        public IWebElement NextMenuOpenCourses => Wait.Until(d => d.FindElement(By.CssSelector(".nav-item.dropdown-item.open > div > div > div.row.titles-row.no-margin-offset.visible-lg.visible-md > div.col-md-8.open-courses-background > h2 > a")));

        public IWebElement NextMenuSearch => Wait.Until(d => d.FindElement(By.CssSelector("#SearchTerm")));

        public IWebElement MenuCourseFound => Wait.Until(d => d.FindElement(By.XPath("//*[@class=\"box-course-button\"]")));
        
        public IWebElement HeadingTag => Wait.Until(d => d.FindElement(By.XPath("//h1[@class=\"text-center\"]")));

        public IWebElement CurrentCourseFound => Wait.Until(d => d.FindElement(By.XPath("//*[@class=\"box-content\"]/h4")));

        public void QACourseNavigationTo()
        {
            UserNavigationSectionMenuObuchenia.Click();
            NextMenuOpenCourses.Click();
            ScrollTo(NextMenuSearch);
            NextMenuSearch.SendKeys("QA Automation");
            NextMenuSearch.SendKeys(Keys.Enter);
            ScrollTo(MenuCourseFound);
            Thread.Sleep(1500);
            MenuCourseFound.Click();
            Thread.Sleep(1500);
            ScrollTo(CurrentCourseFound);
            CurrentCourseFound.Click();
        }
    }
}
