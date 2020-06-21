using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace DemoQAExecise.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        public void Initialize()
        {
            //ChromeOptions options = new ChromeOptions();
            //Driver = new RemoteWebDriver(new Uri("http://192.168.100.5:2323/ wd/ hub"), options);
            //options.AddArgument("-headless");
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
        }

        public void ScreenshotToScreenshotDirectory()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
        }
    }
}
