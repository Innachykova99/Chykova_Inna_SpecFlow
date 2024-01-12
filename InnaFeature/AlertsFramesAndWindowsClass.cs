using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
/*
namespace InnaFeature.AlertsFramesAndWindowsClass
{
   public class AlertsFramesAndWindowsClass
    {
       
   
    public void IAmOnTheAlertsFrameWindowsSection()
        {
            var AlertsFrameAndWindowSection = driver.FindElement(By.XPath("//*[@class='card-body']/h5[contains(text(), 'Alerts, Frame & Windows')]"));
            AlertsFrameAndWindowSection.Click();
        }
        public void IClickBrowserWindowSection(string p0)
        {
            var BrowserWindowSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Browser Windows')]"));
            BrowserWindowSection.Click();
        }

        public void IClickTheNewTabButton(string p0)
        {
            var NewTabButton = driver.FindElement(By.XPath("//*[@id = 'tabButton']"));
            NewTabButton.Click();
        }
        public void ISwitchToTheNewTab()
        {
            var handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles[^1]);
        }
        public void IVerifyThatTheTextIsPresent(string p0)
        {
            var PresentedText = driver.FindElement(By.XPath("//*[@id = 'sampleHeading']"));
            Assert.IsTrue(PresentedText.Displayed);
        }

        public void INavigateToSection(string p0)
        {
            var BrowserWindowSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Browser Windows')]"));
            BrowserWindowSection.Click();
        }
        public void IClickTheNewWindowButton()
        {
            var NewWindowButton = driver.FindElement(By.XPath("//*[@id = 'windowButton']"));
            NewWindowButton.Click();
        }

        public void ISwitchToTheNewWindow()
        {
            driver.SwitchTo().NewWindow(WindowType.Window);
        }

            public void IVerifyThatTheTextIsPresented(string p0)
        {
            var PresentedText = driver.FindElement(By.XPath("//*[@id = 'sampleHeading']"));
            Assert.IsTrue(PresentedText.Displayed);
        }
    }
    

}

*/