﻿using InnaFeature.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace InnaFeature.Steps
{
    [Binding]
    internal class FormsSteps
    {
        private IWebDriver WebDriver;
        private BasePage BasePage;
        private Forms forms;


        [Given(@"User navigates to the category named ""([^""]*)""")]
        public void UserNavigatesToTheCategoryNamedForms(string forms)
        {
            BasePage.NavigateToTheCategory("Forms");
        }

        [When(@"User navigates to the ""([^""]*)"" section")]
        public void WhenUserNavigatesToThePractivceFormSection(string section)
        {
            forms.NavigateToTheSection("Practice Form");
        }


        [When(@"User fills out the text fields with data from the table Examples:")]
        public void UserFillsOutTheTextFieldsWithDataFromTheTableExamples(Table table)
        {
            var firstName = table.Rows[0]["First Name"];
            var lastName = table.Rows[0]["Last Name"];
            var userEmail = table.Rows[0]["Email"];
            var userNumber = table.Rows[0]["Mobile"];
            var currentAddress = table.Rows[0]["Current Address"];

            forms.InputFieldsAndSendKeys("FirstName", firstName);
            forms.InputFieldsAndSendKeys("LastName", lastName);
            forms.InputFieldsAndSendKeys("Email", userEmail);
            forms.InputFieldsAndSendKeys("Mobile", userNumber);
            forms.InputFieldsAndSendKeys("CurrentAddress", currentAddress);
        }

        [When(@"User selects ""([^""]*)"" for Gender")]
        public void WhenISelectFemaleForGender(string gender)
        {
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("arguments[0].click();", forms.FemaleRadioButton);
        }

        [When(@"User fills out the ""([^""]*)"" form with ""([^""]*)""")]
        public void WhenIFillOutTheDateOfBirthFormWithNewDate(string p0, string p1)
        {
            string monthNumber = "5";
            string yearNumber = "1990";
            string dateNumber = "24";

            forms.DateOfBirthForm.Click();
            forms.MonthSelect.Click();
            forms.MonthOption(monthNumber).Click();

            forms.YearSelect.Click();
            forms.YearOption(yearNumber);
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("arguments[0].scrollIntoView(true);", forms.YearOption);

            forms.YearOption(yearNumber).Click();
            forms.DateOption(dateNumber).Click();

        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" in ""([^""]*)"" field")]
        public void WhenIEnterPhysicsAndMathInSubjectsField(string physics, string math, string subjects)
        {
            forms.SubjectsInput.Click();

            var actions = new Actions(WebDriver);
            actions.SendKeys(physics).Perform();
            Thread.Sleep(500);

            actions.SendKeys(Keys.Enter).Perform();
            Thread.Sleep(500);

            actions.SendKeys(math).Perform();
            Thread.Sleep(500);

            actions.SendKeys(Keys.Enter).Perform();

        }



        [When(@"User selects ""([^""]*)"" and ""([^""]*)"" checkboxes for ""([^""]*)""")]
        public void WhenISelectReadingAndMusicCheckboxesForHobbies(string reading, string music, string hobbies)
        {
            var actions = new Actions(WebDriver);

            IWebElement readingCheckbox = forms.HobbiesCheckbox(reading);
            actions.Click(readingCheckbox).Perform();

            IWebElement musicCheckbox = forms.HobbiesCheckbox(music);
            actions.Click(musicCheckbox).Perform();

        }

        [When(@"User selects ""([^""]*)"" for ""([^""]*)"" dropdown and ""([^""]*)"" for ""([^""]*)"" dropdown")]
        public void WhenUserSelectsDropdowns(string p0, string state, string merrut, string city)
        {

            string stateName = "Uttar Pradesh";
            string cityName = "Merrut";

            forms.StateCityDdls(state).Click();
            forms.StateCityOptions(stateName).Click();

            forms.StateCityDdls(city).Click();
            forms.StateCityOptions(cityName).Click();
        }

        [When(@"User submits the form")]
        public void WhenUserSubmitsTheForm()
        {
            forms.SubmitFormButton.Click();
        }

        [Then(@"User verifies the data in the modal matches the input data")]
        public void ThenIVerifyTheDataInTheModalMatchesTheInputData(Table table)
        {
            string studentName = table.Rows[0]["Student Name"];
            string studentEmail = table.Rows[0]["Student Email"];
            string gender = table.Rows[0]["Gender"];
            string mobile = table.Rows[0]["Mobile"];
            string dateOfBirth = table.Rows[0]["Date of Birth"];
            string subjects = table.Rows[0]["Subjects"];
            string hobbies = table.Rows[0]["Hobbies"];
            string address = table.Rows[0]["Address"];
            string stateAndCity = table.Rows[0]["State and City"];
        }

        public void VerifyTheDataInTheModalMatchesTheInputData(string studentName, string studentEmail, string gender, string mobile, string dateOfBirth, string subjects, string hobbies, string address, string stateAndCity)
        {
            {
                VerifyDataInModal("Student Name", studentName);
                VerifyDataInModal("Student Email", studentEmail);
                VerifyDataInModal("Gender", gender);
                VerifyDataInModal("Mobile", mobile);
                VerifyDataInModal("Date of Birth", dateOfBirth);
                VerifyDataInModal("Subjects", subjects);
                VerifyDataInModal("Hobbies", hobbies);
                VerifyDataInModal("Address", address);
                VerifyDataInModal("State and City", stateAndCity);
            }
        }
        public void VerifyDataInModal(string fieldName, string expectedValue)
        {
            Console.WriteLine($"Verifying {fieldName}: Expected - {expectedValue}");
        }

    }
}

        