using InnaFeature.Helpers.Browser;
using InnaFeature.Pages;
using NUnit.Framework;

namespace InnaFeature.Steps
{
    [Binding]
    internal class InteractionsSteps
    {
        private readonly BasePage basePage;
        private readonly Interactions interactions;
        private readonly IBrowserHelper browserHelper;

        public InteractionsSteps(IBrowserHelper browserHelper)
        {
            this.browserHelper = browserHelper;
            basePage = new BasePage(browserHelper);
            interactions = new Interactions(browserHelper);
        }

        [Given(@"User navigates to the category ""([^""]*)""")]
        public void NavigateToTheInteractionsCategory(string category)
        {
            basePage.NavigateToTheCategory(category);
        }

        [When(@"User navigates to section ""([^""]*)""")]
        public void NavigateToSelectableSection(string section)
        {
            basePage.NavigateToTheSection(section);
        }

        [When(@"User clicks on Grid tab")]
        public void NavigateToGridTab()
        {
            interactions.GridTab.Click();
        }

        [When(@"User selects squares ""([^""]*)""")]
        public void SelectSquares(string squareNumbers)
        {
            var squares = squareNumbers.Split(',');

            foreach (string squareNumber in squares)
            {
                interactions.SquareElement(squareNumber).Click();
            }
        }

        [Then(@"User verifies the selected values are One, Three, Five, Seven, and Nine respectively")]
        public void VeriftySelectedSquares()
        {
            List<string> expectedValues = new List<string> { "One", "Three", "Five", "Seven", "Nine" };
            List<string> actualValues = new List<string>();

            foreach (var element in interactions.SelectedSquareElements())
            {
                actualValues.Add(element.Text);
            }

            expectedValues.Count.Should().Be(actualValues.Count, "Incorrect number of selected values");

            for (int i = 0; i < expectedValues.Count; i++)
            {
                expectedValues[i].Should().BeEquivalentTo(actualValues[i], $"Value at index {i} does not match");
            }
        }
    }
}