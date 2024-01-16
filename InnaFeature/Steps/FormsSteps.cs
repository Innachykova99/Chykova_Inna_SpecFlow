using InnaFeature.Helpers.Browser;
using InnaFeature.Models;
using InnaFeature.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow.Assist;

namespace InnaFeature.Steps
{
    [Binding]
    internal class FormsSteps
    {
        private readonly BasePage basePage;
        private readonly Forms forms;
        private readonly IBrowserHelper browserHelper;
        private readonly List<string> formLabels = new List<string>()
        {
            "Student Name",
            "Student Email",
            "Gender",
            "Mobile",
            "Date of Birth",
            "Subjects",
            "Hobbies",
            "Picture",
            "Address",
            "State and City"
        };

        public FormsSteps(IBrowserHelper browserHelper)
        {
            this.browserHelper = browserHelper;
            basePage = new BasePage(browserHelper);
        }

        [Given(@"User is on the ""([^""]*)"" homepage")]
        public void GivenUserIsOnTheHomepage(string applicationUnderTestUrl)
        {
            this.browserHelper.WebDriver.Navigate().GoToUrl(applicationUnderTestUrl);
        }


        //[Given(@"User is on the https://demoqa\.com/ homepage")]
        //public void GivenUserIsOnTheHttpsDemoqa_ComHomepage()
        //{
        //    BrowserHelper = new BrowserHelper();
        //    BrowserHelper.GetDriver();
        //}

        [Given(@"User navigates to the category named ""([^""]*)""")]
        public void UserNavigatesToTheCategoryNamedForms(string categoryName)
        {
            basePage.NavigateToTheCategory(categoryName);
        }

        [When(@"User navigates to the ""([^""]*)"" section")]
        public void WhenUserNavigatesToThePractivceFormSection(string sectionName)
        {
            basePage.NavigateToTheSection(sectionName);
        }

        [When(@"User fills out the text fields with data from the table")]
        public void UserFillsOutTheTextFieldsWithDataFromTheTable(Table table)
        {
            //var firstName = table.Rows[0]["First Name"];
            //var lastName = table.Rows[0]["Last Name"];
            //var userEmail = table.Rows[0]["Email"];
            //var userNumber = table.Rows[0]["Mobile"];
            //var currentAddress = table.Rows[0]["Current Address"];

            var userInputData = table.CreateInstance<UserInputData>();

            forms.InputFieldsAndSendKeys("FirstName", userInputData.FirstName);
            forms.InputFieldsAndSendKeys("LastName", userInputData.LastName);
            forms.InputFieldsAndSendKeys("Email", userInputData.Email);
            forms.InputFieldsAndSendKeys("Mobile", userInputData.Mobile);
            forms.InputFieldsAndSendKeys("CurrentAddress", userInputData.CurrentAddress);
        }

        [When(@"User selects ""([^""]*)"" for Gender")]
        public void UserSelectsFemaleForGender(string gender)
        {
            IWebElement radioButtonToClick = null;
            switch (gender)
            {
                case "Male":
                    throw new NotImplementedException();
                    break;
                case "Female":
                    radioButtonToClick = forms.FemaleRadioButton;
                    break;
            }

            
            ((IJavaScriptExecutor)browserHelper.WebDriver).ExecuteScript("arguments[0].click();", radioButtonToClick);
        }

        [When(@"User fills out the ""([^""]*)"" form with ""([^""]*)""")]
        public void UserFillsOutTheDateOfBirthFormWithNewDate(string p0, string p1)
        {
            string monthNumber = "5";
            string yearNumber = "1990";
            string dateNumber = "24";

            forms.DateOfBirthForm.Click();
            forms.MonthSelect.Click();
            forms.MonthOption(monthNumber).Click();

            forms.YearSelect.Click();
            forms.YearOption(yearNumber);
            ((IJavaScriptExecutor)browserHelper.WebDriver).ExecuteScript("arguments[0].scrollIntoView(true);", forms.YearOption);

            forms.YearOption(yearNumber).Click();
            forms.DateOption(dateNumber).Click();

        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" in Subjects field")]
        public void UserEntersPhysicsAndMathInSubjectsField(string subject1, string subject2)
        {
            forms.SubjectsInput.Click();

            var actions = new Actions(browserHelper.WebDriver);
            actions.SendKeys(subject1).Perform();
            Thread.Sleep(500);

            actions.SendKeys(Keys.Enter).Perform();
            Thread.Sleep(500);

            actions.SendKeys(subject2).Perform();
            Thread.Sleep(500);

            actions.SendKeys(Keys.Enter).Perform();

        }


        [When(@"User selects ""([^""]*)"" and ""([^""]*)"" checkboxes for ""([^""]*)""")]
        public void UserSelectsReadingAndMusicCheckboxesForHobbies(string reading, string music, string hobbies)
        {
            var actions = new Actions(browserHelper.WebDriver);

            IWebElement readingCheckbox = forms.HobbiesCheckbox(reading);
            actions.Click(readingCheckbox).Perform();

            IWebElement musicCheckbox = forms.HobbiesCheckbox(music);
            actions.Click(musicCheckbox).Perform();

        }

        [When(@"User selects ""([^""]*)"" for ""([^""]*)"" dropdown and ""([^""]*)"" for ""([^""]*)"" dropdown")]
        public void UserSelectsDropdowns(string p0, string state, string merrut, string city)
        {

            string stateName = "Uttar Pradesh";
            string cityName = "Merrut";

            forms.StateCityDdls(state).Click();
            forms.StateCityOptions(stateName).Click();

            forms.StateCityDdls(city).Click();
            forms.StateCityOptions(cityName).Click();
        }

        [When(@"User submits the form")]
        public void UserSubmitsTheForm()
        {
            forms.SubmitFormButton.Click();
        }

        [Then(@"User verifies the data in the modal matches the input data")]
        public void UserVerifesTheDataInTheModalMatchesTheInputData(Table table)
        {
            var userInputData = table.CreateInstance<UserInputData>();
        }

        private void VerifyTheDataInTheModalMatchesTheInputData(UserInputData actualData)
        {
            {
                //VerifyDataInModal("StudentName", actualData.FirstName + " " + actualData.LastName);
                //VerifyDataInModal("StudentEmail", actualData.Email);
                //VerifyDataInModal("Gender", actualData.Gender);
                //VerifyDataInModal("Mobile", actualData.Mobile);
                //VerifyDataInModal("DateOfBirth", actualData.DateOfBirth);
                //VerifyDataInModal("Subjects", actualData.Subjects);
                //VerifyDataInModal("Hobbies", actualData.Hobbies);
                //VerifyDataInModal("Address", actualData.CurrentAddress);
                //VerifyDataInModal("StateAndCity", actualData.State + " " + actualData.City);
            }
        }
        //public void VerifyDataInModal(string fieldName, string expectedValue)
        //{
        //    Console.WriteLine($"Verifying {fieldName}: Expected - {expectedValue}");
        //}

        private void VerifyData(UserInputData expectedData)
        {
            FormData actualData = new FormData();

        }
    }
}

        