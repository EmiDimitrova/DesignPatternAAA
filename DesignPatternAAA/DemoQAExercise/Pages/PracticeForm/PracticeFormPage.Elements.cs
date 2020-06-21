using OpenQA.Selenium;

namespace DemoQAExecise.Pages.PracticeForm
{
    public partial class PracticeFormPage : BasePage
    {
        public PracticeFormSection Popup => new PracticeFormSection(Driver);

        public IWebElement FirstName => Wait.Until(d => d.FindElement(By.Id("firstName")));

        public IWebElement LastName => Wait.Until(d => d.FindElement(By.Id("lastName")));

        public IWebElement Email => Wait.Until(d => d.FindElement(By.Id("userEmail")));

        public IWebElement Gender(string labelText) => Wait.Until(d => d.FindElement(By.XPath($"//*[@id='genterWrapper']//label[text()='{labelText}']")));

        public IWebElement PhoneNumber => Wait.Until(d => d.FindElement(By.Id("userNumber")));

        public IWebElement SportsCheckBox => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"hobbiesWrapper\"]/div[2]/div[1]/label")));

        public IWebElement Submit => Wait.Until(d => d.FindElement(By.Id("submit")));
    }
}
