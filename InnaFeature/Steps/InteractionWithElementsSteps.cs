using InnaFeature.Helpers.Browser;
using InnaFeature.Models;
using InnaFeature.Pages;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow.Assist;


namespace InnaFeature.Steps
{
    [Binding]
    internal class InteractionWithElementsSteps
    {
        private readonly BasePage basePage;
        private readonly InteractionWithElements interactionWithElements;
        private readonly IBrowserHelper browserHelper;

        public InteractionWithElementsSteps(IBrowserHelper browserHelper)
        {
            this.browserHelper = browserHelper;
            basePage = new BasePage(browserHelper);
            interactionWithElements = new InteractionWithElements(browserHelper);
        }


        [When(@"User navigates to section ""([^""]*)""")]
        public void NavigateToSelectableSection(string section)
        {
            basePage.NavigateToTheSection(section);
        }

        [When(@"User completes the form with (.*) and (.*) and (.*) and (.*)")]
        public void CompleteTheForm(Table table)
        {
            var formTestData = table.CreateInstance<FormTestData>();

            interactionWithElements.InputFieldsAndSendKeys("FullName", formTestData.FullName);
            interactionWithElements.InputFieldsAndSendKeys("Email", formTestData.Email);
            interactionWithElements.InputFieldsAndSendKeys("CurrentAddress", formTestData.CurrentAddress);
            interactionWithElements.InputFieldsAndSendKeys("PermanentAddress", formTestData.PermanentAddress);

        }

        [When(@"User clicks Submit button")]
        public void ClickOnSubmit()
        {
            interactionWithElements.SubmitButton.Click();
        }

        [Then(@"User verifies that (.*) and (.*) and (.*) and (.*) match the table content")]
        public void VerifyTableContent(string fullName, string email, string currentAddress, string permanentAddress)
        {
            var expectedData = new FormTestData
            {
                FullName = fullName,
                Email = email,
                CurrentAddress = currentAddress,
                PermanentAddress = permanentAddress
            };
        }

        [Given(@"User navigates to the the category named ""([^""]*)""")]
        public void NavigateToTheElementsCategory(string category)
        {
            basePage.NavigateToTheCategory(category);
        }

        [When(@"User expands the folder named ""([^""]*)""")]
        public void ExpandTheFolderNamedHome(string folderNameExpand)
        {
            interactionWithElements.FolderExpand(folderNameExpand).Click();
        }

        [When(@"User selects the ""([^""]*)"" folder without expanding it")]
        public void SelectTheFolderWithoutExpanding()
        {
            interactionWithElements.DesktopCheckbox.Click();
        }

        [When(@"User expands the ""([^""]*)"" folder")]
        public void ExpandDocumentsFolder(string folderNameExpand)
        {
            interactionWithElements.FolderExpand(folderNameExpand).Click();
        }

        [When(@"User expands the ""([^""]*)"" folder")]
        public void ExpandWorkSpaceFolder(string folderNameExpand)
        {
            interactionWithElements.FolderExpand(folderNameExpand).Click();
        }

        [When(@"User selects ""([^""]*)"" and ""([^""]*)"" from the WorkSpace folder")]
        public void SelectElementsFromFolder(string element1, string element2)
        {
            interactionWithElements.FolderContainElement(element1).Click();
            interactionWithElements.FolderContainElement(element2).Click();
        }

        [When(@"User expands the ""([^""]*)"" folder")]
        public void ExpandOfficeFolder(string folderNameExpand)
        {
            interactionWithElements.FolderExpand(folderNameExpand);
        }

        [When(@"User clicks on each element in the Office folder one by one")]
        public void SelectEachElement(string officeFile)
        {
            string[] officeElements = { "Public", "Private", "Classified", "General" };
            foreach (string elementLabel in officeElements)
            {
                interactionWithElements.OfficeFolderContainElement(officeFile).Click();

            }
        }

        [When(@"User expands the ""([^""]*)"" folder")]
        public void ExpandTheDownloadsFolder(string folderName)
        {
            interactionWithElements.FolderExpand(folderName);
        }

        [When(@"User selects the entire ""([^""]*)"" folder")]
        public void SelectTheDownloadsFolder()
        {
            interactionWithElements.DownloadsFolderSelect.Click();
        }

        [Then(@"User verifies that the output contains ""([^""]*)""")]
        public void OutputContains(string expectedText)
        {
            var actualText = interactionWithElements.OutputResult.Text;
            actualText.Should().BeEquivalentTo(expectedText);
        }

        [Given(@"User navigates to the the category named ""([^""]*)""")]
        public void NavigateToElementsCategory(string category)
        {
            basePage.NavigateToTheCategory(category);
        }

        [When(@"User clicks on the Salary column header")]
        public void ClickOnColumnHeader()
        {
            interactionWithElements.SalaryColumnHeader.Click();
        }

        [Then(@"User verifies that the Salary column values are in ascending order")]
        public void VerifyThatTheSalaryColumnValuesAreInAscendingOrder()
        {
            //var salaryValues = interactionWithElements.SalaryElements.Select(element => element.Text)
            //                                 .Where(text => double.TryParse(text, out _))
            //                                 .ToList();

            //var isAscending = IsSortedAscending(salaryValues);
            //salaryValues.Should().HaveCount(isAscending.Count);
        }
        public bool IsSortedAscending(List<string> values)
        {
            var numbers = values.Select(double.Parse).ToList();
            var sortedNumbers = new List<double>(numbers);
            sortedNumbers.Sort();

            return numbers.SequenceEqual(sortedNumbers);
        }

        [When(@"User deletes the second row from the table")]
        public void DeleteTheSecondRowFromTheTable()
        {
            interactionWithElements.DeleteSecondRow.Click();
        }

        [Then(@"User checks that there are only two rows left and no ""([^""]*)"" value in the Department column")]
        public void TwoRowsLeftAndNoComplianceValueInTheDepartmentColumn(string unwantedValue)
        {
            //var DepartmentRows = interactionWithElements.RowElements.ToList();



            // unwantedValuePresent.Should().BeFalse($"No {unwantedValue} value should be present in the department column for any row");

            // create list of existing firstnames, use linq (method Exist (+lambda expression) = > receive true/false 
        }


        [Given(@"User navigates to the category ""([^""]*)""")]
        public void NavigateToElementssCategory(string category)
        {
            basePage.NavigateToTheCategory(category);
        }

        [When(@"User performs (.*) on the (.*) button")]
        public void PerformActionsOnButtons(string action, string buttonName)
        {

            Actions actions = new Actions(browserHelper.WebDriver);
            switch (action)
            {
                case "single click":
                    actions.Click(interactionWithElements.ClickMeButtons(buttonName));
                    break;

                case "double click":
                    actions.DoubleClick(interactionWithElements.ClickMeButtons(buttonName));
                    break;

                case "right click":
                    actions.ContextClick(interactionWithElements.ClickMeButtons(buttonName));
                    break;

                default:
                    break;
            }
        }

        [Then(@"User verifies that the respective message appears")]
        public void VerifyThatTheRespectiveMessageAppears(string message) //(string doubleClickMessage, string rightClickMessage, string dynamicClickMessage)
        {
            var displayedMessage = interactionWithElements.MessageAfterClick(message);
            displayedMessage.Displayed.Should().BeTrue($"Expected message '{message}' is not displayed.");
        }

    }

}

