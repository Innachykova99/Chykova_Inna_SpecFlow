using InnaFeature.Helpers.Browser;
using InnaFeature.Models;
using InnaFeature.Pages;
using OpenQA.Selenium.Interactions;


namespace InnaFeature.Steps
{
    [Binding]
    internal class InteractionWithElementsSteps
    {
        private readonly BasePage basePage;
        private readonly InteractionWithElements interactionWithElements;
        private readonly IBrowserHelper browserHelper;
        private FormTestData enteredData;

        public InteractionWithElementsSteps(IBrowserHelper browserHelper)
        {
            this.browserHelper = browserHelper;
            basePage = new BasePage(browserHelper);
            interactionWithElements = new InteractionWithElements(browserHelper);
        }

        [When(@"User completes the form with (.*), (.*), (.*) and (.*)")]
        public void CompleteTheForm(string userName, string userEmail, string currentAddress, string permanentAddress)
        {
            enteredData = new FormTestData
            {
                FullName = userName,
                Email = userEmail,
                CurrentAddress = currentAddress,
                PermanentAddress = permanentAddress
            };

            interactionWithElements.InputFields("userName").SendKeys(userName);
            interactionWithElements.InputFields("userEmail").SendKeys(userEmail);
            interactionWithElements.InputFields("currentAddress").SendKeys(currentAddress);
            interactionWithElements.InputFields("permanentAddress").SendKeys(permanentAddress);
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

        [When(@"User deletes the second row from the table")]
        public void DeleteTheSecondRowFromTheTable()
        {
            interactionWithElements.DeleteSecondRow.Click();
        }

        [When(@"User performs (.*) on the (.*) button")]
        public void PerformActionsOnButtons(string action, string buttonName)
        {
            IWebElement buttonElement = interactionWithElements.ClickMeButtons(buttonName);

            Actions actions = new Actions(browserHelper.WebDriver);
            switch (action)
            {
                case "single click":
                    actions.Click(interactionWithElements.ClickMeButtons(buttonName)).Perform();
                    break;

                case "double click":
                    actions.DoubleClick(interactionWithElements.ClickMeButtons(buttonName)).Perform();
                    break;

                case "right click":
                    actions.ContextClick(interactionWithElements.ClickMeButtons(buttonName)).Perform();
                    break;

                default:
                    break;
            }
        }

        [When(@"User verifies that the Salary column values are in ascending order")]
        public void VerifyThatTheSalaryColumnValuesAreInAscendingOrder()
        {
            var salaryValues = interactionWithElements.SalaryCells;

            var salaryArray = salaryValues.Select(element => element.Text).ToArray();
            var sortedSalaryArray = salaryArray.ToArray();
            Array.Sort(sortedSalaryArray);

            salaryArray.Should().BeEquivalentTo(sortedSalaryArray, "Salary column values are not in ascending order");
        }


        [Then(@"User verifies that (.*) and (.*) and (.*) and (.*) match the table content")]
        public void VerifyTableContent(string enteredName, string email, string currentAddress, string permanentAddress)
        {
            var actualName = interactionWithElements.NameResultAfterSubmit(enteredName).Text;
            var actualEmail = interactionWithElements.EmailResultAfterSubmit(email).Text;
            var actualCurrentAddress = interactionWithElements.CurrentAddressResultAfterSubmit(currentAddress).Text;
            var actualPermanentAddress = interactionWithElements.PermanentAddressResultAfterSubmit(permanentAddress).Text;

            enteredData.FullName.Should().Be(actualName); // 'Expected enteredData.FullName to be "Name:Inna Chykova" with a length of 17, but "Inna Chykova" has a length of 12, differs near "Inn" (index 0).'
            enteredData.Email.Should().Be(actualEmail);
            enteredData.CurrentAddress.Should().Be(actualCurrentAddress);
            enteredData.PermanentAddress.Should().Be(actualPermanentAddress);
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
            var departmentValues = interactionWithElements.DepartmentCells.Select(element => element.Text).ToList();
            departmentValues.Should().NotContain(unwantedValue);
        }

        [Then(@"User verifies that the respective (.*) appears for relevant (.*)")]
        public void VerifyThatTheRespectiveMessageAppears(string message, string buttonId)
        {
            var displayedElements = interactionWithElements.DisplayedMessages(buttonId, message);
            displayedElements.Should().NotBeEmpty($"Expected message '{message}' is not displayed for '{buttonId}'.");
        }

    }

}