using InnaFeature.Helpers.Browser;
using InnaFeature.Pages;
using NUnit.Framework.Legacy;


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

        [Given(@"User navigates to ""([^""]*)"" category")]
        public void GivenUserNavigatesToCategory(string categoryName)
        {
            basePage.NavigateToTheCategory(categoryName);
        }

        [When(@"User navigates to ""([^""]*)"" section")]
        public void WhenUserNavigatesToSection(string sectionName)
        {
            basePage.NavigateToTheSection(sectionName);
        }

        [When(@"User types letter ""([^""]*)"" in the Type multiple color names field")]
        public void WhenUserTypesLetterInTheField(string letter)
        {
            widgets.MultipleColorNamesField.Click();
            widgets.MultipleColorNamesField.SendKeys(letter);
        }

        [When(@"User adds the colors Red, Yellow, Green, Blue, and Purple to the Type multiple color names field")]
        public void WhenUserAddsTheColorsRedYellowGreenBlueAndPurpleToTheField()
        {
            widgets.MultipleColorNamesField.Click();

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

        [When(@"User navigates to the ""([^""]*)"" section")]
        public void WhenUserNavigatesToProgressBarSection(string sectionName)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)browserHelper.WebDriver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", basePage.Section(sectionName));
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
            int maxWaitTimeInSeconds = 15;
            int waitTime = 0;
            int pollingInterval = 1000;

            while (currentProgress < targetProgress && waitTime < maxWaitTimeInSeconds * 1000)
            {
                currentProgress = GetProgressValue(widgets.ProgressBar);
                Thread.Sleep(pollingInterval);
                waitTime += pollingInterval;
            }
            currentProgress.Should().Be(targetProgress);
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
           .Distinct(StringComparer.OrdinalIgnoreCase)
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

        [Then(@"User verifies that the button changes back to Start and the progress is at (.*)")]
        public void ThenUserVerifiesThatTheButtonChangesBackToStartAndTheProgressIsAt(string p0)
        {
            widgets.StartButton.Text.Should().Be("Start");

            var progressText = GetProgressValue(widgets.ProgressBar);

            progressText.Should().Be(0);
        }

    }
}