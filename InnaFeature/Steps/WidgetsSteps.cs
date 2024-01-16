using InnaFeature.Helpers.Browser;
using InnaFeature.Pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace InnaFeature.Steps
{
    [Binding]
    internal class WidgetsSteps
    {
        private readonly BasePage basePage;
        private readonly Widgets widgets;
        private readonly IBrowserHelper browserHelper;
        private readonly List<string> ColorsInField = new List<string>()

            { "Red",
              "Yellow",
              "Green",
              "Blue",
              "Purple"
            };


        public WidgetsSteps(IBrowserHelper browserHelper)
        {
            this.browserHelper = browserHelper;
            basePage = new BasePage(browserHelper);
            widgets = new Widgets(browserHelper);
        }

        [Given(@"User is on the ""([^""]*)"" homepage")]
        public void GivenUserIsOnTheDemoqa_ComHomepage(string applicationUnderTestUrl)
        {
            browserHelper.WebDriver.Navigate().GoToUrl(applicationUnderTestUrl);
        }

        [Given(@"User navigates to ""([^""]*)"" category")]
        public void GivenUserNavigatesToCategory(string categoryName)
        {
            basePage.NavigateToTheCategory(categoryName);
        }

        [Given(@"User goes to the ""([^""]*)"" category")]
        public void GivenUserGoesToTheCategory(string categoryName)
        {
            basePage.NavigateToTheCategory(categoryName);
        }


        [Given(@"User navigates to category ""([^""]*)""")]
        public void GivenUserNavigatesToProgressBarCategory(string categoryName)
        {
            basePage.NavigateToTheCategory(categoryName);
        }

        [When(@"User navigates to ""([^""]*)"" section")]
        public void WhenUserNavigatesToAutoCompleteSection(string sectionName)
        {
            basePage.NavigateToTheSection(sectionName);
        }

        [When(@"User types letter '([^']*)' in the ""([^""]*)"" field")]
        public void WhenUserTypesLetterInTheField(string letter)
        {
            widgets.MultipleColorNamesField.Click();
            widgets.MultipleColorNamesField.SendKeys(letter);
        }

        [When(@"User navigates to ""([^""]*)"" section")]
        public void UserNavigatesToAutoCompleteSection(string sectionName)
        {
            basePage.NavigateToTheSection(sectionName);
        }

        [When(@"User adds the colors Red, Yellow, Green, Blue, and Purple to the ""([^""]*)"" field")]
        public void WhenUserAddsTheColorsRedYellowGreenBlueAndPurpleToTheField()
        {
            widgets.MultipleColorNamesField.Click();
            var actions = new Actions(browserHelper.WebDriver);


            foreach (var color in ColorsInField)
            {
                widgets.MultipleColorNamesField.SendKeys(color);
                Thread.Sleep(500);
                widgets.MultipleColorNamesField.SendKeys(Keys.Enter);
                Thread.Sleep(500);
            }
        }

        [When(@"User removes ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserRemovesYellowAndPurple(string color1, string color2)
        {
            widgets.RemoveColor(color1).Click();
            widgets.RemoveColor(color2).Click();
        }

        [When(@"User navigates to ""([^""]*)"" section")]
        public void WhenUserNavigatesToProgressBarSection(string sectionName)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)browserHelper.WebDriver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", sectionName);
            basePage.NavigateToTheSection(sectionName);
        }

        public int GetProgressValue(IWebElement progressBar)
        {
            string progressText = progressBar.Text;
            string progressValue = progressText.Trim('%');
            if (int.TryParse(progressValue, out int value))
            {
                return value;
            }
            else
            {
                return -1;
            }
        }

        [When(@"User clicks Start and wait until the progress reaches (.*)%")]
        public void WhenUserClicksStartAndWaitUntilTheProgressReaches(int targetProgress)
        {
            widgets.StartButton.Click();
            int currentProgress = 0;
            int maxWaitTimeInSeconds = 10;
            int waitTime = 0;
            int pollingInterval = 1000;

            while (currentProgress < targetProgress && waitTime < maxWaitTimeInSeconds * 1000)
            {
                currentProgress = GetProgressValue(widgets.ProgressBar);
                Thread.Sleep(pollingInterval);
                waitTime += pollingInterval;

            }
            if (currentProgress >= targetProgress)
            {
                Console.WriteLine($"Progress reached {targetProgress}%");
            }
            else
            {
                Console.WriteLine($"Progress did not reach {targetProgress}% within {maxWaitTimeInSeconds} seconds");
            }
        }

        [When(@"User clicks Reset")]
        public void WhenUserClicksReset()
        {
            widgets.ResetButton.Click();
        }

        [Then(@"User verifies that three autocomplete suggestions contain the letter '([^']*)'")]
        public void ThenUserVerifiesThatThreeAutocompleteSuggestionsContainTheLetter(string letter)
        {
            string lowercaseLetter = letter.ToLower();
            var suggestions = widgets.AutoCompleteSuggestions(lowercaseLetter);

            int count = suggestions.Count(suggestion => suggestion.Text.ToLower().Contains(lowercaseLetter));

            count.Should().Be(3);
        }

        [Then(@"User verifies only Red, Green, and Blue remain in the field")]
        public void ThenUserVerifiesOnlyRedGreenAndBlueRemainInTheField()
        {
            var colorTexts = widgets.RemainColors
           .Select(colorElement => colorElement.Text.Trim())
           .Where(colorText => !string.IsNullOrWhiteSpace(colorText))
           .ToList();

            foreach (var colorText in colorTexts)
            {
                Console.WriteLine($"Color Text: {colorText}");
            }
            colorTexts.Count.Should().Be(3);
            CollectionAssert.AreEquivalent(new[] { "Red", "Green", "Blue" }, colorTexts);
        }

        [Then(@"User verifies that the button changes to Reset")]
        public void ThenUserVerifiesThatTheButtonChangesToReset()
        {
            widgets.ResetButton.Text.Should().Be("Reset");
        }

        [Then(@"User verifies that the button changes back to Start and the progress is at (.*)%")]
        public void ThenUserVerifiesThatTheButtonChangesBackToStartAndTheProgressIsAt()
        {
            widgets.StartButton.Text.Should().Be("Start");

            var progressValue = GetProgressValue(widgets.ProgressBar);
            progressValue.Should().Be(0);
        }

    }
}