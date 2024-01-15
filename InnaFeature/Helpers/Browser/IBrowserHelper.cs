using OpenQA.Selenium;

namespace InnaFeature.Helpers.Browser
{
    interface IBrowserHelper
    {
        IWebDriver WebDriver { get; }

        void Teardown();
    }
}
