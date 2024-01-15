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
        public IWebElement Section(string section) =>
           WebDriver.FindElement(By.XPath($"//*[@class='text'][contains(text(), '{section}')]"));

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