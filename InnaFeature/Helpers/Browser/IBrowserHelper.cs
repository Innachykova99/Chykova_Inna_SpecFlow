using OpenQA.Selenium;

namespace InnaFeature.Helpers.Browser
{
    internal interface IBrowserHelper
    {
        public IWebDriver WebDriver { get; }

        public void Teardown();
    }
}
