using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class InteractionWithElements : BasePage
    {
        public InteractionWithElements(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement Section(string section) =>
           WebDriver.FindElement(By.XPath($"//*[@class='text'][contains(text(), '{section}')]")); //this element is defined in every class. Should be on BasePage?
        public IWebElement InputFields(string fieldname) =>
            WebDriver.FindElement(By.XPath($"//*[@id='{fieldname}']"));
        public IWebElement SubmitButton =>
            WebDriver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement HomeFolderExpand =>
            WebDriver.FindElement(By.XPath("//*[@class='rct-text']/button")); //finds several elements (and for DocumentsFolderExpand, WorkSpaceFolderExpand, OfficeFolderExpand, DownloadsFolderExpand)
        public IWebElement DesktopCheckbox =>
            WebDriver.FindElement(By.XPath("//*[@for = 'tree-node-desktop']/span[@class = 'rct-checkbox']"));
        public IWebElement WorkSpaceFolderContainElement(string workspacefile) =>
            WebDriver.FindElement(By.XPath($"//*[@for = 'tree-node-{workspacefile}']/span[@class = 'rct-checkbox']")); // will be angular and veu
        public IWebElement OfficeFolderContainElement(string officefile) =>
            WebDriver.FindElement(By.XPath($"//*[@for = 'tree-node-{officefile}']/span[@class = 'rct-checkbox']")); // will be public, private, classified, general
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
