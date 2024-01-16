using InnaFeature.Helpers.Browser;
using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class BasePage
    {
        protected IBrowserHelper browserHelper;

        public BasePage(IBrowserHelper browserhelper)
        {
            browserHelper = browserhelper ?? throw new ArgumentNullException(nameof(browserhelper));

        }

        public IWebElement ElementsTypeButtonByName(string name) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@class='card-body']/h5[contains(text(), '{name}')]"));
        public IWebElement Section(string section) =>
           browserHelper.WebDriver.FindElement(By.XPath($"//*[@class='text'][contains(text(), '{section}')]"));

        public void NavigateToTheCategory(string categoryName)
        {
            IWebElement categoryButton = ElementsTypeButtonByName(categoryName);
            categoryButton.Click();
        }

        public void NavigateToTheSection(string sectionName)
        {
            IWebElement sectionButton = Section(sectionName);
            sectionButton.Click();
        }


    }

}