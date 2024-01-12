using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
/*
namespace InnaFeature.InteractionWithElementsClass
{
    public class InteractionWithElements
        { 
         public class FormTestData
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string CurrentAddress { get; set; }
            public string PermanentAddress { get; set; }
        }

        public class FeatureSteps
        {
            private readonly DriverHelper driverHelper = new DriverHelper();
            public FormTestData GetActualDataFromForm()
            {
                var FullNameInput = driverHelper.GetDriver().FindElement(By.XPath("//*[@id='userName']")).GetAttribute("value");
                var EmailInput = driverHelper.GetDriver().FindElement(By.XPath("//*[@id='userEmail']")).GetAttribute("value");
                var CurrentAddressInput = driverHelper.GetDriver().FindElement(By.XPath("//*[@id='currentAddress']")).GetAttribute("value");
                var PermanentAddressInput = driverHelper.GetDriver().FindElement(By.XPath("//*[@id= 'permanentAddress']")).GetAttribute("value");

                var ActualData = new FormTestData
                {
                    FullName = FullNameInput,
                    Email = EmailInput,
                    CurrentAddress = CurrentAddressInput,
                    PermanentAddress = PermanentAddressInput
                };

                return ActualData;
            }
        }
       

        public void INavigateToTheCategoryAndSection(string category, string section)
        {
            var ElementsCategory = driver.FindElement(By.XPath($"//*[@class=\"card-body\"]/h5[contains(text(), 'Elements')]"));
            ElementsCategory.Click();
            var TextBoxSection = driver.FindElement(By.XPath($"//*[@class='text'][contains(text(), 'Text Box')]"));
            TextBoxSection.Click();
        }
        public void ICompleteTheFormWithFullNameAndEmailAndCurrentAddressAndPermanentAddress(string fullName, string email, string currentAddress, string permanentAddress)
        {
            Table table = new Table(new string[] { "FullName", "Email", "CurrentAddress", "PermanentAddress" });
            table.AddRow(fullName, email, currentAddress, permanentAddress);
            var formData = table.CreateInstance<FormTestData>();

            var FullNameInput = driver.FindElement(By.XPath("//*[@id='userName']"));
            var EmailInput = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            var CurrentAddressInput = driver.FindElement(By.Id("currentAddress"));
            var PermanentAddressInput = driver.FindElement(By.Id("permanentAddress"));

            FullNameInput.SendKeys(formData.FullName);
            EmailInput.SendKeys(formData.Email);
            CurrentAddressInput.SendKeys(formData.CurrentAddress);
            PermanentAddressInput.SendKeys(formData.PermanentAddress);
        }
        public void IClickOnSubmit(string submit)
        {
            var SubmitButton = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            SubmitButton.Click();
        }
        private FeatureSteps steps = new FeatureSteps();
        public void IVerifyThatAllEnteredDataMatchesTheTableContent(Table ExpectedData)
        {
            FormTestData ActualData = steps.GetActualDataFromForm();
            var expectedData = ExpectedData.CreateInstance<FormTestData>();

            Assert.That(ActualData.FullName, Is.EqualTo(expectedData.FullName));
            Assert.That(ActualData.Email, Is.EqualTo(expectedData.Email));
            Assert.That(ActualData.CurrentAddress, Is.EqualTo(expectedData.CurrentAddress));
            Assert.That(ActualData.PermanentAddress, Is.EqualTo(expectedData.PermanentAddress));
        }
         */

/*
public void INavigateToTheTheCategoryNamedElementsAndCheckBoxSection(string category, string section)
{
    var ElementsCategory = driver.FindElement(By.XPath($"//*[@class=\"card-body\"]/h5[contains(text(), 'Elements')]"));
    ElementsCategory.Click();
    var CheckBoxSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Check Box')]"));
    CheckBoxSection.Click();
}

public void IExpandTheFolderNamedHome(string home)
{
    var HomeFolderExpand = driver.FindElement(By.XPath("//*[@class='rct-text']/button")); //several elements
    HomeFolderExpand.Click();
}
public void ISelectTheFolderWithoutExpandingIt(string folderName)
{
    var DesktopCheckbox = driver.FindElement(By.XPath("//*[@for = 'tree-node-desktop']/span[@class = 'rct-checkbox']"));
    DesktopCheckbox.Click();
}
public void IExpandDocumentsAndWorkSpaceFolders(string folder1, string folder2)
{
    var DocumentsFolderExpand = driver.FindElement(By.XPath("//*[@class='rct-text']/button")); //several elements
    DocumentsFolderExpand.Click();

    var WorkSpaceFolderExpand = driver.FindElement(By.XPath("//*[@class='rct-text']/button")); //several elements
    WorkSpaceFolderExpand.Click();
}
public void ISelectAngularAndVeuElementsFromWorkSpaceFolder(string element1, string element2, string foldername)
{
    var AngularElement = driver.FindElement(By.XPath("//*[@for = 'tree-node-angular']/span[@class = 'rct-checkbox']"));
    var VeuElement = driver.FindElement(By.XPath("//*[@for = 'tree-node-veu']/span[@class = 'rct-checkbox']"));
    AngularElement.Click();
    VeuElement.Click();
}
public void IExpandOfficeFolder(string folderName)
{
    var OfficeFolderExpand = driver.FindElement(By.XPath("//*[@class='rct-text']/button")); //several elements
    OfficeFolderExpand.Click();
}
public void IClickOnEachElementInTheOfficeFolder(string office)
{
    var PublicElement = driver.FindElement(By.XPath("//*[@for = 'tree-node-public']/span[@class = 'rct-checkbox']"));
    var PrivateElement = driver.FindElement(By.XPath("//*[@for = 'tree-node-private']/span[@class = 'rct-checkbox']"));
    var ClassfiedElement = driver.FindElement(By.XPath("//*[@for = 'tree-node-classified']/span[@class = 'rct-checkbox']"));
    var GeneralElement = driver.FindElement(By.XPath("//*[@for = 'tree-node-general']/span[@class = 'rct-checkbox']"));
    PublicElement.Click();
    PrivateElement.Click();
    ClassfiedElement.Click();
    GeneralElement.Click();
}
public void IExpandTheDownloadsFolder(string folderName)
{
    var DownloadsFolderExpand = driver.FindElement(By.XPath("//*[@class='rct-text']/button")); //several elements
    DownloadsFolderExpand.Click();
}
public void ISelectTheEntireFolder(string folderName)
{
    var DownloadsFolder = driver.FindElement(By.XPath("//*[@for = 'tree-node-downloads']//span[@class = 'rct-title']"));
    DownloadsFolder.Click();
}
public void IVerifyThatTheOutputContains(string ExpectedText)
{
    resultElement = driver.FindElement(By.XPath("//*[@id = 'result']"));
    var ActualText = resultElement.Text;
    Assert.That(ActualText, Is.EqualTo(ExpectedText));
}
public void INavigateToTheElementsCategoryAndSectionNamedWebTables(string category, string section)
{
    var ElementsCategory = driver.FindElement(By.XPath($"//*[@class='card-body']/h5[contains(text(), 'Elements')]"));
    ElementsCategory.Click();
    var WebTablesSection = driver.FindElement(By.XPath($"//*[@class='text'][contains(text(), 'Web Tables')]"));
    WebTablesSection.Click();
}
public void IClickOnTheSalaryColumnHeader()
{
    var SalaryColumnHeader = driver.FindElement(By.XPath("//*[@class='rt-tr']//div[contains(text(), 'Salary')]"));
    SalaryColumnHeader.Click();
}

private IWebElement resultElement;
public bool IsSortedAscending(List<string> values)
{
    var numbers = values.Select(double.Parse).ToList();
    var sortedNumbers = new List<double>(numbers);
    sortedNumbers.Sort();

    return numbers.SequenceEqual(sortedNumbers);
}
public void IVerifyThatTheSalaryColumnValuesAreInAscendingOrder()
{
    var salaryElements = driver.FindElements(By.XPath("//*[@class = 'rt-tbody']"));

    var salaryValues = salaryElements.Select(element => element.Text)
                                     .Where(text => double.TryParse(text, out _))
                                     .ToList();

    var isAscending = IsSortedAscending(salaryValues);


    Assert.That(IsSortedAscending(salaryValues), Is.True);
}
public void IDeleteTheSecondRowFromTheTable()
{
    var DeleteSecondRow = driver.FindElement(By.XPath("//span[@id = 'delete-record-1']"));
    DeleteSecondRow.Click();
}
public void ICheckThatThereAreOnlyTwoRowsLeftAndNoComplianceValueInTheDepartmentColumn(string compliance)
{
    var departmentCells = driver.FindElements(By.XPath(".//div[@class = 'rt-tr-group']")); //each cell in each row
}
public void INavigateToTheElementsCategoryAndButtonsSection(string elements, string buttons)
{
    var ElementsCategory = driver.FindElement(By.XPath($"//*[@class='card-body']/h5[contains(text(), 'Elements')]"));
    ElementsCategory.Click();
    var ButtonsSection = driver.FindElement(By.XPath($"//*[@class='text'][contains(text(), 'Buttons')]"));
    ButtonsSection.Click();
}
public void IPerformActionsOnButtons(string action0, string buttonName)
{
    switch (buttonName)
    {
        case "Click Me":
            var SingleClick = driver.FindElement(By.XPath("//*[@id='VKyR9'][contains(text(), 'Click Me')]"));
            Actions singleClickAction = new Actions(driver);
            singleClickAction.Click(SingleClick).Perform();
            var waitSingleClick = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitSingleClick.Until(driver => driver.FindElement(By.XPath("//*[@id=\"dynamicClickMessage\"]")).Displayed);

            break;

        case "Double CLick Me":
            var DoubleClickMe = driver.FindElement(By.XPath("//*[@id = 'doubleClickBtn']"));
            Actions doubleClickAction = new Actions(driver);
            doubleClickAction.DoubleClick(DoubleClickMe).Perform();

            var waitDoubleClick = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitDoubleClick.Until(driver => driver.FindElement(By.XPath("//*[@id=\"doubleClickMessage\"]")).Displayed);
            break;

        case "Right Click Me":
            var RightClick = driver.FindElement(By.XPath("//*[@id = 'rightClickBtn']"));
            Actions rightClickAction = new Actions(driver);
            rightClickAction.ContextClick(RightClick).Perform();

            var waitRightClick = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitRightClick.Until(driver => driver.FindElement(By.XPath("//*[@id=\"rightClickMessage\"]")).Displayed);

            break;

        default:
            break;
    }
}
public void IVerifyThatTheRespectiveMessageAppears()
{
    var doubleClickMessage = driver.FindElement(By.XPath($"//*[@id=\"doubleClickMessage\"]"));
    Assert.IsTrue(doubleClickMessage.Displayed);
    var rightClickMessage = driver.FindElement(By.XPath($"//*[@id=\"rightClickMessage\"]"));
    Assert.IsTrue(rightClickMessage.Displayed);
    var singleClickMessage = driver.FindElement(By.XPath($"//*[@id=\"dynamicClickMessage\"]"));
    Assert.IsTrue(singleClickMessage.Displayed);
}
}
}
*/