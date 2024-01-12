using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
/*
namespace InnaFeature.WidgetsClass
{
    public class WidgetsClass
    { 
    
        public void NavigateToWidgetsCategoryAndAutocompleteSection()
        {
            var WidgetsCategory = driver.FindElement(By.XPath("//*[@class='card-body']/h5[contains(text(), 'Widgets')]"));
            WidgetsCategory.Click();
            var AutoCompleteSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Auto Complete')]"));
            AutoCompleteSection.Click();
        }
        public void TypeLetterInField(string letter, string field)
        {
            var MultipleColorNames = driver.FindElement(By.XPath("//*[@id=\"autoCompleteMultipleInput\"]"));
            letter = "g";
            MultipleColorNames.Click();
            MultipleColorNames.SendKeys(letter);
        }

        public void VerifyAutocompleteSuggestions(string letter)
        {
            letter = "g";
            string lowercaseLetter = letter.ToLower();
            var Suggestions = driver.FindElements(By.XPath($"//*[@id=\"autoCompleteMultipleContainer\"]//*[contains(@class, 'auto-complete__menu-list')]//div[contains(translate(text(), 'G', 'g'), '{lowercaseLetter}')]"));
            int count = 0;

            foreach (var s in Suggestions)
            {
                if (s.Text.ToLower().Contains(lowercaseLetter))
                {
                    count++;
                }
            }
            Assert.AreEqual(3, count);

        }

        public void GoToTheWidgetsCategoryAndAutocompleteSection(string widgets, string p1)
        {
            var WidgetsCategory = driver.FindElement(By.XPath("//*[@class='card-body']/h5[contains(text(), 'Widgets')]"));
            WidgetsCategory.Click();
            var AutoCompleteSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Auto Complete')]"));
            AutoCompleteSection.Click();
        }

        public void AddColorsToTheField(string p0)
        {
            var MultipleColorNames = driver.FindElement(By.XPath("//*[@id=\"autoCompleteMultipleInput\"]"));
            MultipleColorNames.Click();
            var actions = new Actions(driver);

            var colors = new List<string> { "Red", "Yellow", "Green", "Blue", "Purple" };
            foreach (var color in colors)
            {
                MultipleColorNames.SendKeys(color);
                Thread.Sleep(500);
                MultipleColorNames.SendKeys(Keys.Enter);
                Thread.Sleep(500);
            }
        }

        public void RemoveColors()
        {
            var RemovePurpleColor = driver.FindElement(By.XPath("//*[@id=\"autoCompleteMultipleContainer\"]//*[contains(@class, 'auto-complete__multi-value') and contains(text(), 'Purple')]/following::*[contains(@class, 'auto-complete__multi-value__remove')]"));
            RemovePurpleColor.Click();
            var RemoveYellowColor = driver.FindElement(By.XPath("//*[@id=\"autoCompleteMultipleContainer\"]//*[contains(@class, 'auto-complete__multi-value') and contains(text(), 'Yellow')]/following::*[contains(@class, 'auto-complete__multi-value__remove')]"));
            RemoveYellowColor.Click();
        }

        public void VerifyRemainColorsInTHeField()
        {
            var remainingColors = driver
        .FindElements(By.XPath("//*[@id=\"autoCompleteMultipleContainer\"]//*[contains(@class, 'auto-complete__multi-value')]"))
        .Select(colorElement => colorElement.Text)
        .Distinct();

            foreach (var colorText in remainingColors)
            {
                if (!string.IsNullOrWhiteSpace(colorText))
                {
                    Console.WriteLine($"Color Text: {colorText}");
                }
            }
        }

        public void NavigateToWidgetsCategoryAndProgressBarSection(string widgets, string p1)
        {
            var WidgetsCategory = driver.FindElement(By.XPath("//*[@class='card-body']/h5[contains(text(), 'Widgets')]"));
            WidgetsCategory.Click();
            var ProgressBarSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Progress Bar')]"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", ProgressBarSection);
            ProgressBarSection.Click();
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

        public void ClickStartAndWaitUntilTheProgressReaches(int targetProgress)
        {
            var StartButton = driver.FindElement(By.XPath("//*[@id = 'startStopButton']"));
            StartButton.Click();
            var ProgressBar = driver.FindElement(By.XPath("//*[@id = 'progressBar']"));
            int currentProgress = 0;
            int maxWaitTimeInSeconds = 10;
            int waitTime = 0;
            int pollingInterval = 1000;

            while (currentProgress < targetProgress && waitTime < maxWaitTimeInSeconds * 1000)
            {
                currentProgress = GetProgressValue(ProgressBar);
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

        public void VerifyThatTheButtonChangesToReset()
        {
            var ResetButton = driver.FindElement(By.XPath("//*[@id = 'resetButton']"));
            Assert.AreEqual("Reset", ResetButton.Text);
        }
        public void IClickReset()
        {
            var ResetButton = driver.FindElement(By.XPath("//*[@id = 'resetButton']"));
            ResetButton.Click();
        }
        public void VerifyThatTheButtonChangesBackToStartAndTheProgressIsAt(int p0)
        {
            var StartButton = driver.FindElement(By.XPath("//*[@id = 'startStopButton']"));
            var ProgressBar = driver.FindElement(By.XPath("//*[@id = 'progressBar']"));
            Assert.AreEqual("Start", StartButton.Text);

            var progressValue = GetProgressValue(ProgressBar);
            Assert.AreEqual(0, progressValue);
        }
    }
}
*/