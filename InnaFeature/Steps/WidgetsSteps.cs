using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics.Metrics;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using static System.Collections.Specialized.BitVector32;
/*
namespace InnaFeature.Steps
{
    [Binding]
    internal class WidgetsSteps
    {
        

        [Given(@"I navigate to ""([^""]*)"" category and ""([^""]*)"" section")]
        public void GivenINavigateToWidgetsCategoryAndAutocompleteSection(string widgets, string p1)
        {
            driverHelper.NavigateToWidgetsCategoryAndAutocompleteSection();
        }

        [When(@"I type letter '([^']*)' in the ""([^""]*)"" field")]
        public void WhenITypeLetterInTheField(string letter, string field)
        {
            driverHelper.TypeLetterInField(letter, field);
        }

        [Then(@"I verify three autocomplete suggestions contain the letter '([^']*)'")]
        public void ThenIVerifyThreeAutocompleteSuggestionsContainTheLetter(string letter)
        {
            driverHelper.VerifyAutocompleteSuggestions(letter);
        }

        [Given(@"I go to the ""([^""]*)"" category and ""([^""]*)"" section")]
        public void GivenIGoToTheWidgetsCategoryAndAutocompleteSection(string widgets, string p1)
        {
            driverHelper.GoToTheWidgetsCategoryAndAutocompleteSection(widgets, p1);
        }

        [When(@"I add the colors Red, Yellow, Green, Blue, and Purple to the ""([^""]*)"" field")]
        public void WhenIAddTheColorsRedYellowGreenBlueAndPurpleToTheField(string p0)
        {
            driverHelper.AddColorsToTheField(p0);
        }

        [When(@"I remove Yellow and Purple")]
        public void WhenRemoveYellowAndPurple()
        {
            driverHelper.RemoveColors();
        }

        [Then(@"I verify only Red, Green, and Blue remain in the field")]
        public void ThenIVerifyOnlyRedGreenAndBlueRemainInTheField()
        {
            driverHelper.VerifyRemainColorsInTHeField();
        }



        [Given(@"I navigate to category ""([^""]*)"" and ""([^""]*)"" section")]
        public void GivenINavigateToWidgetsCategoryAndProgressBarSection(string widgets, string p1)
        {
            driverHelper.NavigateToWidgetsCategoryAndProgressBarSection(widgets, p1);
        }


        [When(@"I click Start and wait until the progress reaches (.*)%")]
        public void WhenIClickStartAndWaitUntilTheProgressReaches(int targetProgress)
        {
            driverHelper.ClickStartAndWaitUntilTheProgressReaches(targetProgress);

        }

        [Then(@"I verify that the button changes to Reset")]
        public void ThenIVerifyThatTheButtonChangesToReset()
        {
            driverHelper.VerifyThatTheButtonChangesToReset();
        }

        [When(@"I click Reset")]
        public void WhenIClickReset()
        {
            driverHelper.IClickReset();
        }

        [Then(@"I verify that the button changes back to Start and the progress is at (.*)%")]
        public void ThenIVerifyThatTheButtonChangesBackToStartAndTheProgressIsAt(int p0)
        {
            driverHelper.VerifyThatTheButtonChangesBackToStartAndTheProgressIsAt(p0);

        }
    }
}

*/