using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class Interactions : BasePage
    {
        public Interactions(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement Section(string section) =>
           WebDriver.FindElement(By.XPath($"//*[@class='text'][contains(text(), '{section}')]")); //this element is defined in every class. Should be on BasePage?
        public IWebElement GridTab =>
            WebDriver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']"));
        public IWebElement SquareElement(string squareNumber) =>
            WebDriver.FindElement(By.XPath($"//li[contains(text(), '{squareNumber}')]"));
        public IWebElement SelectedSquareElement =>
            WebDriver.FindElement(By.XPath("//*[@id='demo-tabpane-grid']//li[contains(@class, 'active')]"));
    }
}
