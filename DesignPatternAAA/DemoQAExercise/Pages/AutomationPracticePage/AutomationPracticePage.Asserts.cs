using DemoQAExecise.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OldHomeworks.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public void AssertRegisterFormOpened()
        {
            Assert.AreEqual("YOUR PERSONAL INFORMATION", AccountCreation.Text);
        }

        public void AssertErrorMissingFirstName()
        {
            Assert.AreEqual("firstname is required.", Message.Text);
        }

        public void AssertErrorMissingLastName()
        {
            Assert.AreEqual("lastname is required.", Message.Text);
        }

        public void AssertErrorMissingPhoneNumber()
        {
            Assert.AreEqual("You must register at least one phone number.", Message.Text);
        }

        public void AssertErrorMissingPassword()
        {
            Assert.AreEqual("passwd is required.", Message.Text);
        }

        public void AssertErrorMissingAddress()
        {
            Assert.AreEqual("address1 is required.", Message.Text);
        }
    }
}
