using OpenQA.Selenium;

namespace DemoQAExecise.Pages.PracticeForm
{
    public class PracticeFormSection : BasePage
    {
        public PracticeFormSection(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement Message => Wait.Until(d => d.FindElement(By.Id("example-modal-sizes-title-lg")));
    }
}
