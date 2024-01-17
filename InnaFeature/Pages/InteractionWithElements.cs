using InnaFeature.Helpers.Browser;
using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class InteractionWithElements : BasePage
    {
        public InteractionWithElements(IBrowserHelper browserHelper) : base(browserHelper)
        {

        }
        public IWebElement InputFields(string fieldname) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='{fieldname}']"));

        public IWebElement SubmitButton =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id='submit']"));

        public IWebElement FolderExpand(string folderNameExpand) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//label[@for='tree-node-{folderNameExpand}']/preceding-sibling::button"));
        
        public IWebElement DesktopCheckbox =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@for = 'tree-node-desktop']/span[@class = 'rct-checkbox']"));
        
        public IWebElement FolderContainElement(string fileName) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@for = 'tree-node-{fileName}']/span[@class = 'rct-checkbox']"));
        
        public IReadOnlyCollection<IWebElement> OfficeFolderContain(string officeFile) =>
            browserHelper.WebDriver.FindElements(By.XPath($"//*[@for = 'tree-node-{officeFile}']"));
        
        public IWebElement DownloadsFolderSelect =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@for = 'tree-node-downloads']//span[@class = 'rct-title']"));
       
        public IWebElement OutputResult =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id = 'result']"));
       
        public IWebElement SalaryColumnHeader =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@class='rt-tr']//div[contains(text(), 'Salary')]"));
        
        public IWebElement SalaryElements =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@class = 'rt-tbody']"));
        
        public IWebElement DeleteSecondRow =>
            browserHelper.WebDriver.FindElement(By.XPath("//span[@id = 'delete-record-1']"));
        
        public IWebElement RowElements =>
            browserHelper.WebDriver.FindElement(By.XPath(".//div[@class = 'rt-tr-group']")); //all cells in each row
        
        public IEnumerable<IWebElement> DepartmentCells(string departmentValue) =>
            browserHelper.WebDriver.FindElements(By.XPath($".//div[@class='rt-table']//div[@class='rt-tbody']//div[@class='rt-tr-group']//div[@class='rt-td' and contains(text(), '{departmentValue}')]"));
       
        public IWebElement ClickMeButtons(string buttonName) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id = '{buttonName}']"));

        public IReadOnlyCollection<IWebElement> displayedMessages(string buttonId, string message) =>
            browserHelper.WebDriver.FindElements(By.XPath($"//*[@id='{buttonId}' and contains(text(), '{message}')]"));

        public void InputFieldsAndSendKeys(string fieldname, string value)
        {
            IWebElement inputField = InputFields(fieldname);
            inputField.Clear();
            inputField.SendKeys(value);

        }
    }
}