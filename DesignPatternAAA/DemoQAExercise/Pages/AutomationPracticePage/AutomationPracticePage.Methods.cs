using AutoFixture;
using DemoQAExecise.Pages;
using OldHomeworks.Models;
using OpenQA.Selenium;

namespace OldHomeworks.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public AutomationPracticePage(IWebDriver driver) : base(driver)
        {
            
        }

        public string RandomEmail()
        {
            var fixture = new Fixture();
            var randomMail = fixture.Create<string>()+ "@gmail.com";
            return randomMail;

        }

        public void FillForm(AutomationPracticeModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            CountryField.SendKeys(user.CountryField + Keys.Tab);
            StateField.SendKeys(user.CountryField + Keys.Tab);
            //CountryFieldd(user.CountryField).Click();
            //StateFieldd(user.StateField).Click();
            PostalCode.SendKeys(user.PostalCode);
            PhoneNumber.SendKeys(user.PhoneNumber);

            ScrollTo(RegisterButton).Click();
        }

        public void FillFormAndRegisterButtonClick(AutomationPracticeModel _user)
        {
            FillForm(_user);
            PageLoad();
        }

        
    }
}
