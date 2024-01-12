using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class Widgets : BasePage
    {
        public Widgets(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement Section(string section) =>
           WebDriver.FindElement(By.XPath($"//*[@class='text'][contains(text(), '{section}')]"));
        public IWebElement MultipleColorNamesField =>
            WebDriver.FindElement(By.XPath("//*[@id='autoCompleteMultipleInput']"));
        public IWebElement AutocompleteSuggestions(string lowercaseLetter) =>
            WebDriver.FindElement(By.XPath($"//*[@id='autoCompleteMultipleContainer']//*[contains(@class, 'auto-complete__menu-list')]//div[contains(translate(text(), 'G', 'g'), '{lowercaseLetter}')]"));
        public IWebElement RemoveColor(string removecolor) =>
            WebDriver.FindElement(By.XPath($"//*[@id='autoCompleteMultipleContainer']//*[contains(@class, 'auto-complete__multi-value') and contains(text(), '{removecolor}')]/following::*[contains(@class, 'auto-complete__multi-value__remove')]"));
        public IWebElement RemainColors =>
            WebDriver.FindElement(By.XPath("//*[@id='autoCompleteMultipleContainer']//*[contains(@class, 'auto-complete__multi-value')]"));
        public IWebElement StartButton =>
            WebDriver.FindElement(By.XPath("//*[@id = 'startStopButton']"));
        public IWebElement ProgressBar =>
            WebDriver.FindElement(By.XPath("//*[@id = 'progressBar']"));
        public IWebElement ResetButton =>
            WebDriver.FindElement(By.XPath("//*[@id = 'resetButton']"));

    }
}
