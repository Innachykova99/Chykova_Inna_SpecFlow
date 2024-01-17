using InnaFeature.Helpers.Browser;
using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class Widgets : BasePage
    {
        public Widgets(IBrowserHelper browserHelper) : base (browserHelper)
        {

        }

        public IWebElement MultipleColorNamesField =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id='autoCompleteMultipleInput']"));

        public IReadOnlyCollection<IWebElement> AutoCompleteSuggestions(string lowercaseLetter) =>
            browserHelper.WebDriver.FindElements(By.XPath($"//*[@id='autoCompleteMultipleContainer']//*[contains(@class, 'auto-complete__menu-list')]//div[contains(translate(text(), 'G', 'g'), '{lowercaseLetter}')]"));

        public IWebElement RemoveColor(string removecolor) =>
             browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='autoCompleteMultipleContainer']//*[contains(@class, 'auto-complete__multi-value') and contains(text(), '{removecolor}')]/following::*[contains(@class, 'auto-complete__multi-value__remove')]"));
        
        public IReadOnlyCollection<IWebElement> RemainColors =>
            browserHelper.WebDriver.FindElements(By.XPath("//*[@id='autoCompleteMultipleContainer']//*[contains(@class, 'auto-complete__multi-value')]"));
        
        public IWebElement StartButton =>
             browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'startStopButton']"));
        
        public IWebElement ProgressBar =>
             browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'progressBar']"));

        public IWebElement ResetButton =>
             browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'resetButton']"));
    }
}