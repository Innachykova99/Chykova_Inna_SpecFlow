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

        [When(@"User expands the ""([^""]*)"" folder")]
        public void ExpandTheFolder(string folderNameExpand)
        {
            interactionWithElements.FolderExpand(folderNameExpand).Click();
        }

        [When(@"User selects the Desktop folder without expanding it")]
        public void SelectTheFolderWithoutExpanding()
        {
            interactionWithElements.DesktopCheckbox.Click();
        }

        [When(@"User selects ""([^""]*)"" and ""([^""]*)"" from the WorkSpace folder")]
        public void SelectElementsFromFolder(string element1, string element2)
        {
            interactionWithElements.FolderContainElement(element1).Click();
            interactionWithElements.FolderContainElement(element2).Click();
        }

        [When(@"User clicks on each element in the ""([^""]*)"" folder one by one")]
        public void SelectEachElement(string officeFile)
        {
            string[] officeElements = { "Public", "Private", "Classified", "General" };
            var folderElements = interactionWithElements.OfficeFolderContain(officeFile);

            foreach (var element in folderElements)
            {
                element.Click();
            }

        }

        [When(@"User selects the entire Downloads folder")]
        public void SelectTheDownloadsFolder()
        {
            interactionWithElements.DownloadsFolderSelect.Click();
        }

        [When(@"User clicks on the Salary column header")]
        public void ClickOnColumnHeader()
        {
            interactionWithElements.SalaryColumnHeader.Click();
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

        [When(@"User verifies that the Salary column values are in ascending order")]
        public void VerifyThatTheSalaryColumnValuesAreInAscendingOrder()
        {
            //var salaryValues = interactionWithElements.SalaryElements.Select(element => element.Text)
            //                                 .Where(text => double.TryParse(text, out _))
            //                                 .ToList();

            //var isAscending = IsSortedAscending(salaryValues);
            //salaryValues.Should().HaveCount(isAscending.Count);
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

        [Then(@"User verifies that the output contains ""([^""]*)""")]
        public void OutputContains(string expectedText)
        {
            var actualText = interactionWithElements.OutputResult.Text;

            var actualLines = actualText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var actualSingleLine = string.Join(" ", actualLines);

            expectedText.Should().Be(actualSingleLine);
        }

        [Then(@"User checks that there are only two rows left and no ""([^""]*)"" value in the Department column")]
        public void TwoRowsLeftAndNoComplianceValueInTheDepartmentColumn(string unwantedValue)
        {
            //var DepartmentRows = interactionWithElements.RowElements.ToList();



            // unwantedValuePresent.Should().BeFalse($"No {unwantedValue} value should be present in the department column for any row");

            // create list of existing firstnames, use linq (method Exist (+lambda expression) = > receive true/false 
        }

        [Then(@"User verifies that the respective (.*) appears")]
        public void VerifyThatTheRespectiveMessageAppears(string message)
        {

            //var displayedMessages = interactionWithElements.displayedMessages(message);


            //displayedMessages.Should().NotBeEmpty($"Expected message '{message}' is not displayed.");
        }

    }

}