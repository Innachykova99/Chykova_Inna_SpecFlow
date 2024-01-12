using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class BasePage
    {
        protected IWebDriver WebDriver;

        public BasePage(IWebDriver driver)
        {
            WebDriver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public IWebElement ElementsTypeButtonByName(string name) =>
            WebDriver.FindElement(By.XPath($"//*[@class='card-body']/h5[contains(text(), '{name}')]"));

        public void NavigateToTheCategory(string categoryName)
        {
            IWebElement categoryButton = ElementsTypeButtonByName(categoryName);
            categoryButton.Click();
        }


    }



}