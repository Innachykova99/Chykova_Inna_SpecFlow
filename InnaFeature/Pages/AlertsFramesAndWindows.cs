using InnaFeature.Helpers.Browser;
using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class AlertsFramesAndWindows : BasePage
    {
        public AlertsFramesAndWindows(IBrowserHelper browserHelper) : base(browserHelper)
        {

        }
        public IWebElement NewTabButton =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'tabButton']"));
        public IWebElement PresentedText =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'sampleHeading' and contains(text(), 'This is a sample page')]"));
        public IWebElement NewWindowButton =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'windowButton']"));


    }

}