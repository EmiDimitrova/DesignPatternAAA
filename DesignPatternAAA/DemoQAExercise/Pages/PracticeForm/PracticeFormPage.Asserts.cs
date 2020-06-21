using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQAExecise.Pages.PracticeForm
{
    public partial class PracticeFormPage : BasePage
    {
        public void AssertErrorBorderColor(IWebElement element)
        {
            var actualBorderColor = element.GetCssValue("border-color");
            Assert.AreNotEqual("rgb(40, 167, 69)", actualBorderColor);
        }
    }
}
