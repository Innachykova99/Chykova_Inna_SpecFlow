using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
/*
namespace InnaFeature.InteractionsCLass
{
    public class InteractionsClass
    { 

        public void INavigateToTheInteractionsCategoryAndSelectableSection(string interactions, string selectable)
        {
            var InteractionsCategory = driver.FindElement(By.XPath("//*[@class=\"card-body\"]/h5[contains(text(), 'Interactions')]"));
            InteractionsCategory.Click();
            var SelectableSection = driver.FindElement(By.XPath("//*[@class='text'][contains(text(), 'Selectable')]"));
            SelectableSection.Click();
        }

        public void IClickOnTheTab(string grid)
        {
            var GridTab = driver.FindElement(By.XPath("//*[@id = 'demo-tab-grid']"));
            GridTab.Click();
        }

        public void ISelectSquares(int p0, int p1, int p2, int p3, int p4)
        {
            string[] squareNumbersToSelect = new string[] { "One", "Three", "Five", "Seven", "Nine" };

            foreach (string squareNumber in squareNumbersToSelect)
            {
                var squareElement = driver.FindElement(By.XPath($"//li[contains(text(), '{squareNumber}')]"));
                squareElement.Click();
            }
        }

        public void IVerifyTheSelectedValuesAreOneThreeFiveSevenAndNineRespectively()
        {
            List<string> expectedValues = new List<string> { "One", "Three", "Five", "Seven", "Nine" };
            List<string> actualValues = new List<string>();

            var selectedElements = driver.FindElements(By.XPath("//*[@id='demo-tabpane-grid']//li[contains(@class, 'active')]"));

            foreach (var element in selectedElements)
            {
                actualValues.Add(element.Text);
            }

            Assert.AreEqual(expectedValues.Count, actualValues.Count, "Incorrect number of selected values");

            for (int i = 0; i < expectedValues.Count; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i], $"Value at index {i} does not match");
            }
        }
    }
}


*/