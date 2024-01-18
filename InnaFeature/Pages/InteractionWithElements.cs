using InnaFeature.Helpers.Browser;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

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

        public IWebElement NameResultAfterSubmit(string enteredName) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='name' and contains(., '{enteredName}')]"));
        public IWebElement EmailResultAfterSubmit(string enteredEmail) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='email' and contains(., '{enteredEmail}')]"));
        public IWebElement CurrentAddressResultAfterSubmit(string enteredCurrentAddress) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='currentAddress' and contains(., '{enteredCurrentAddress}')]"));
        public IWebElement PermanentAddressResultAfterSubmit(string enteredPermanentAddress) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='permanentAddress' and contains(., '{enteredPermanentAddress}')]"));

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

        public IWebElement DeleteSecondRow =>
            browserHelper.WebDriver.FindElement(By.XPath("//span[@id = 'delete-record-2']"));

        public IList<IWebElement> SalaryCells =>
            browserHelper.WebDriver.FindElements(By.XPath("//div[@role='row' and not(ancestor::div[contains(@class, 'rt-thead')])]/div[5]"));

        public IList<IWebElement> DepartmentCells =>
            browserHelper.WebDriver.FindElements(By.XPath("//div[@role='row' and not(ancestor::div[contains(@class, 'rt-thead')])]/div[6]"));

        public IWebElement ClickMeButtons(string buttonName) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[text()='{buttonName}']"));

        public IReadOnlyCollection<IWebElement> DisplayedMessages(string buttonId, string message) =>
            browserHelper.WebDriver.FindElements(By.XPath($"//*[@id='{buttonId}' and contains(text(), '{message}')]"));

        public void InputFieldsAndSendKeys(string fieldname, string value)
        {
            IWebElement inputField = InputFields(fieldname);
            inputField.Clear();
            inputField.SendKeys(value);

        }
       
    }
}