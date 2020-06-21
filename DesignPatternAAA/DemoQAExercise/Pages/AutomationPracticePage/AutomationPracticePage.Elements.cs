using DemoQAExecise.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OldHomeworks.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public IWebElement SignInButton => Wait.Until(d => d.FindElement(By.PartialLinkText(@"Sign in")));

        public IWebElement EmailInput => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"email_create\"]")));

        public IWebElement FirstName => Wait.Until(d => d.FindElement(By.Id("customer_firstname")));   

        public IWebElement LastName => Wait.Until(d => d.FindElement(By.Id("customer_lastname")));

        public IWebElement Password => Wait.Until(d => d.FindElement(By.Id("passwd")));

        public IWebElement Address => Wait.Until(d => d.FindElement(By.Id("address1")));

        public IWebElement City => Wait.Until(d => d.FindElement(By.Id("city")));

        public IWebElement CountryField => Wait.Until(d => d.FindElement(By.Id("id_country")));
        public IWebElement CountryFieldd(string labelText) => Wait.Until(d => d.FindElement(By.XPath("//div[@id='uniform-id_country']//label[text()='{labelText}']")));

        public IWebElement StateField => Wait.Until(d => d.FindElement(By.Id("id_state")));
        public IWebElement StateFieldd(string labelText) => Wait.Until(d => d.FindElement(By.XPath("//div[@id='uniform-id_state']//label[text()='{labelText}']")));

        public IWebElement PostalCode => Wait.Until(d => d.FindElement(By.Id("postcode")));

        public IWebElement PhoneNumber => Wait.Until(d => d.FindElement(By.Id("phone")));

        public IWebElement RegisterButton => Wait.Until(d => d.FindElement(By.Id("submitAccount")));

        public IWebElement Message => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"center_column\"]/div/ol/li")));

        public IWebElement AccountCreation => Wait.Until(d => d.FindElement(By.XPath("//*/div[1]/h3")));

    }
}
