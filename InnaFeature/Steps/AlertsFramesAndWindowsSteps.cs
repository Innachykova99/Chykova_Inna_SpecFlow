using InnaFeature.Helpers.Browser;
using InnaFeature.Pages;
using NUnit.Framework;

namespace InnaFeature.Steps
{
    [Binding]
    internal class AlertsFramesAndWindowsSteps
    {
        private readonly BasePage basePage;
        private readonly AlertsFramesAndWindows alertsFramesAndWindows;
        private readonly IBrowserHelper browserHelper;

        public AlertsFramesAndWindowsSteps(IBrowserHelper browserHelper)
        {
            this.browserHelper = browserHelper;
            basePage = new BasePage(browserHelper);
            alertsFramesAndWindows = new AlertsFramesAndWindows(browserHelper);
        }

        [Given(@"User is on ""([^""]*)"" homepage")]
        public void GivenUserIsOnTheHomepage(string applicationUnderTestUrl)
        {
            browserHelper.WebDriver.Navigate().GoToUrl(applicationUnderTestUrl);
        }

        [Given(@"User is on the ""([^""]*)"" category")]
        public void GivenUserIsOnTheSection(string category)
        {
            basePage.NavigateToTheCategory(category);
        }

        [When(@"User clicks ""([^""]*)"" section")]
        public void WhenUserClicksSection(string section)
        {
            basePage.NavigateToTheSection(section);
        }

        [When(@"User clicks the New Tab button")]
        public void WhenUserClicksTheNewTabButton()
        {
            alertsFramesAndWindows.NewTabButton.Click();
        }

        [When(@"User clicks the New Window button")]
        public void WhenUserClicksTheNewWindowButton()
        {
            alertsFramesAndWindows.NewWindowButton.Click();
        }

        [When(@"User switches to the new tab")]
        public void WhenUserSwitchesToTheNewTab()
        {
            var handles = browserHelper.WebDriver.WindowHandles;
            browserHelper.WebDriver.SwitchTo().Window(handles[^1]);
        }

        [When(@"User switches to the new window")]
        public void WhenUserSwitchesToTheNewWindow()
        {
            var handles = browserHelper.WebDriver.WindowHandles;
            if (handles.Count >= 2)
            {
                browserHelper.WebDriver.SwitchTo().Window(handles[1]);
            }
            else
            {

            }
        }

        [Then(@"User verifies that the text This is a sample page is presented")]
        public void ThenUserVerifiesThatTheTextIsPresented()
        {
            alertsFramesAndWindows.PresentedText.Displayed.Should().BeTrue("The text is not displayed");
        }
    }
}