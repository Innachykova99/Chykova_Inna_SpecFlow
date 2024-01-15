using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InnaFeature.Pages;

namespace InnaFeature.Steps
{
    [Binding]
    internal class AlertsFramesAndWindowsSteps
    {
        private readonly IWebDriver WebDriver;
        private BasePage BasePage;
        private AlertsFramesAndWindows alertsFramesAndWindows;

        [Given(@"User is on the ""([^""]*)"" category")]
        public void GivenUserIsOnTheSection(string category)
        {
            BasePage.NavigateToTheCategory("Alerts, Frames and Windows");
        }

        [When(@"User clicks ""([^""]*)"" section")]
        public void WhenUserClicksSection(string section)
        {
            BasePage.NavigateToTheSection("Browser Window");
        }

        [When(@"User clicks the ""([^""]*)"" button")]
        public void WhenUserClicksTheButton()
        {
            alertsFramesAndWindows.NewTabButton.Click();
        }

        [When(@"User switches to the new tab")]
        public void WhenUserSwitchesToTheNewTab()
        {
            throw new PendingStepException();
        }

        [Then(@"User verifies that the text ""([^""]*)"" is present")]
        public void ThenUserVerifiesThatTheTextIsPresent(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"User navigates to ""([^""]*)"" section")]
        public void WhenUserNavigatesToSection(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"User switches to the new window")]
        public void WhenUserSwitchesToTheNewWindow()
        {
            throw new PendingStepException();
        }

        [Then(@"User verifies that the text ""([^""]*)"" is presented")]
        public void ThenUserVerifiesThatTheTextIsPresented(string p0)
        {
            throw new PendingStepException();
        }
    }
}




/*
namespace InnaFeature.Steps
{
   [Binding]
   internal class AlertsFramesAndWindowsSteps
   {
     //private readonly WebDriver driverHelper = new WebDriver();


       [Given(@"I am on the Alerts, Frame & Windows section")]
       public void GivenIAmOnTheAlertsFrameWindowsSection()
       {
           driverHelper.IAmOnTheAlertsFrameWindowsSection();
       }

       [Given(@"I click ""([^""]*)"" section")]
       public void GivenIClickBrowserWindowSection(string p0)
       {
           driverHelper.IClickBrowserWindowSection(p0);
       }

       [Given(@"I click the ""([^""]*)"" button")]
       public void GivenIClickTheNewTabButton(string p0)
       {
           driverHelper.IClickTheNewTabButton(p0);
       }

       [Given(@"I navigate to ""([^""]*)"" section")]
       public void GivenINavigateToSection(string p0)
       {
           driverHelper.INavigateToSection(p0);
       }

       [Given(@"I click the New Window button")]
       public void GivenIClickTheNewWindowButton()
       {
           driverHelper.IClickTheNewWindowButton();
       }

       [When(@"I switch to the new tab")]
       public void WhenISwitchToTheNewTab()
       {
           driverHelper.ISwitchToTheNewTab();
       }

       [When(@"I switch to the new window")]
       public void WhenISwitchToTheNewWindow()
       {
           driverHelper.ISwitchToTheNewWindow();
       }

       [Then(@"I verify that the text ""([^""]*)"" is presented")]
       public void ThenIVerifyThatTheTextIsPresented(string p0)
       {
           driverHelper.IVerifyThatTheTextIsPresented(p0);
       }

       [Then(@"I verify that the text ""([^""]*)"" is present")]
       public void ThenIVerifyThatTheTextIsPresent(string p0)
       {
           driverHelper.IVerifyThatTheTextIsPresent(p0);
       }
   }
}
     */