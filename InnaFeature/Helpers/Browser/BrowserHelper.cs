using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace InnaFeature.Helpers.Browser
{
    internal class BrowserHelper : IBrowserHelper
    {
        public IWebDriver WebDriver { get; private set; }

        public BrowserHelper()
        {
            WebDriver = GetDriver();
        }

        public void Teardown()
        {
            if (WebDriver != null)
            {
                WebDriver.Close();
                WebDriver.Quit();
            }
        }

        private IWebDriver GetDriver()
        {
            if (WebDriver == null)
            {
                WebDriver = new ChromeDriver();
                WebDriver.Manage().Cookies.DeleteAllCookies();
                WebDriver.Navigate().GoToUrl("https://demoqa.com/");
                WebDriver.Manage().Window.Maximize();
            }
            return WebDriver;
        }

    }
}