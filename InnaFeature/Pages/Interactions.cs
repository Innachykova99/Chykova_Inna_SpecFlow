using InnaFeature.Helpers.Browser;

namespace InnaFeature.Pages
{
    internal class Interactions : BasePage
    {
        public Interactions(IBrowserHelper browserHelper) : base(browserHelper)
        {

        }
        public IWebElement GridTab =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']"));

        public IWebElement SquareElement(string squareNumber) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//li[contains(text(), '{squareNumber}')]"));

        public IReadOnlyCollection<IWebElement> SelectedSquareElements() =>
            browserHelper.WebDriver.FindElements(By.XPath("//*[@id='demo-tabpane-grid']//li[contains(@class, 'active')]"));
    }
}