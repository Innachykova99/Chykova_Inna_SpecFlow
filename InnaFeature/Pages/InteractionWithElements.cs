using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class InteractionWithElements : BasePage
    {
        public InteractionWithElements(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement InputFields(string fieldname) =>
            WebDriver.FindElement(By.XPath($"//*[@id='{fieldname}']"));
        public IWebElement SubmitButton =>
            WebDriver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement HomeFolderExpand (string folderNameExpand) =>
            WebDriver.FindElement(By.XPath($"//label[@for='tree-node-{folderNameExpand}']/preceding-sibling::button")); 
        public IWebElement DesktopCheckbox =>
            WebDriver.FindElement(By.XPath("//*[@for = 'tree-node-desktop']/span[@class = 'rct-checkbox']"));
        public IWebElement WorkSpaceFolderContainElement(string workspacefile) =>
            WebDriver.FindElement(By.XPath($"//*[@for = 'tree-node-{workspacefile}']/span[@class = 'rct-checkbox']")); 
        public IWebElement OfficeFolderContainElement(string officefile) =>
            WebDriver.FindElement(By.XPath($"//*[@for = 'tree-node-{officefile}']/span[@class = 'rct-checkbox']")); 
        public IWebElement DownloadsFolderSelect =>
            WebDriver.FindElement(By.XPath("//*[@for = 'tree-node-downloads']//span[@class = 'rct-title']"));
        public IWebElement OutputResult =>
            WebDriver.FindElement(By.XPath("//*[@id = 'result']"));
        public IWebElement SalaryColumnHeader =>
            WebDriver.FindElement(By.XPath("//*[@class='rt-tr']//div[contains(text(), 'Salary')]"));
        public IWebElement SalaryElements =>
            WebDriver.FindElement(By.XPath("//*[@class = 'rt-tbody']"));
        public IWebElement DeleteSecondRow =>
            WebDriver.FindElement(By.XPath("//span[@id = 'delete-record-1']"));
        public IWebElement DepartmentCells =>
            WebDriver.FindElement(By.XPath(".//div[@class = 'rt-tr-group']")); //each cell in each row
        public IWebElement ClickMeButtons(string buttonName) =>
            WebDriver.FindElement(By.XPath($"//*[@id = '{buttonName}']"));
        public IWebElement MessageAfterClick(string message) =>
            WebDriver.FindElement(By.XPath($"//*[@id= '{message}']"));



    }
}
