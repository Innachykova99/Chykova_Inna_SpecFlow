using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Runtime.InteropServices;
using NUnit.Framework.Constraints;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Support.UI;
/*
namespace InnaFeature.Steps
{
    [Binding]
    internal class InteractionWithElementsSteps
    {
        private readonly DriverHelper driverHelper = new DriverHelper();

        /*  [When(@"I navigate to the ""([^""]*)"" category and ""([^""]*)"" section")]
          public void WhenINavigateToTheCategoryAndSection(string category, string section)
          {
             driverHelper.INavigateToTheCategoryAndSection(category, section);

          }

          [When(@"I complete the form with (.*) and (.*) and (.*) and (.*)")]
          public void WhenICompleteTheFormWithFullNameAndEmailAndCurrentAddressAndPermanentAddress(string fullName, string email, string currentAddress, string permanentAddress)
          {
              driverHelper.ICompleteTheFormWithFullNameAndEmailAndCurrentAddressAndPermanentAddress(fullName, currentAddress, permanentAddress, email);
          }


          [When(@"I click on ""([^""]*)""")]
          public void WhenIClickOnSubmit(string submit)
          {
              driverHelper.IClickOnSubmit(submit);
          }



          [Then(@"I verify that (.*) and (.*) and (.*) and (.*) match the table content")]
          public void ThenIVerifyThatAllEnteredDataMatchesTheTableContent(Table ExpectedData)
          {
              driverHelper.IVerifyThatAllEnteredDataMatchesTheTableContent(ExpectedData);
          }

           

        [Given(@"I navigate to the the category named ""([^""]*)"" and ""([^""]*)"" section")]
        public void GivenINavigateToTheTheCategoryNamedElementsAndCheckBoxSection(string category, string section)
        {
            driverHelper.INavigateToTheTheCategoryNamedElementsAndCheckBoxSection(category, section);
        }

        [Given(@"I expand the folder named ""([^""]*)""")]
        public void GivenIExpandTheFolderNamedHome(string home)
        {
            driverHelper.IExpandTheFolderNamedHome(home);
        }

        [Given(@"I select the ""([^""]*)"" folder without expanding it")]
        public void GivenISelectTheFolderWithoutExpandingIt(string folderName)
        {
            driverHelper.ISelectTheFolderWithoutExpandingIt(folderName);
        }

        [Given(@"I expand the ""([^""]*)"" folder and ""([^""]*)"" folder")]
        public void GivenIExpandDocumentsAndWorkSpaceFolders(string folder1, string folder2)
        {
           driverHelper.IExpandDocumentsAndWorkSpaceFolders(folder1, folder2);
        }

        [Given(@"I select ""([^""]*)"" and ""([^""]*)"" from the ""([^""]*)"" folder")]
        public void GivenISelectAngularAndVeuElementsFromWorkSpaceFolder(string element1, string element2, string foldername)
        {
            driverHelper.ISelectAngularAndVeuElementsFromWorkSpaceFolder(element1, element2, foldername);
        }

        [Given(@"I expand the ""([^""]*)"" folder")]

        public void GivenIExpandOfficeFolder(string folderName)
        {
            driverHelper.IExpandOfficeFolder(folderName);
        }

        [When(@"I click on each element in the ""([^""]*)"" folder one by one")]
       
        public void WhenIClickOnEachElementInTheOfficeFolder (string office)
        {
            driverHelper.IClickOnEachElementInTheOfficeFolder(office);
        }

        [When (@"I expand the ""([^""]*)"" folder")]
        public void AndIExpandTheDownloadsFolder (string folderName)
        {
           driverHelper.IExpandTheDownloadsFolder(folderName);
        }

        [When(@"I select the entire ""([^""]*)"" folder")]
        public void WhenISelectTheEntireFolder(string folderName)
        {
            driverHelper.ISelectTheEntireFolder (folderName);
        
        }

        [Then(@"I verify that the output contains ""([^""]*)""")]
        public void ThenIVerifyThatTheOutputContains(string ExpectedText)
        { 
        driverHelper.IVerifyThatTheOutputContains (ExpectedText);
        }




        [Given(@"I navigate to the ""([^""]*)"" category and section named ""([^""]*)""")]
        public void GivenINavigateToTheElementsCategoryAndSectionNamedWebTables(string category, string section)
        {
         
            driverHelper.INavigateToTheElementsCategoryAndSectionNamedWebTables (category, section);
        }

    [When(@"I click on the Salary column header")]
        public void WhenIClickOnTheSalaryColumnHeader()
        {
           driverHelper.IClickOnTheSalaryColumnHeader();
        }
       
        

        [Then(@"I verify that the Salary column values are in ascending order")]
        public void ThenIVerifyThatTheSalaryColumnValuesAreInAscendingOrder()
        {
            driverHelper.IVerifyThatTheSalaryColumnValuesAreInAscendingOrder();
        }



        [Then(@"I delete the second row from the table")]
        public void ThenIDeleteTheSecondRowFromTheTable()
        {
           driverHelper.IDeleteTheSecondRowFromTheTable();
        }

        [Then(@"I check that there are only two rows left and no ""([^""]*)"" value in the Department column")]
        public void ThenICheckThatThereAreOnlyTwoRowsLeftAndNoComplianceValueInTheDepartmentColumn(string compliance)
        {
            driverHelper.ICheckThatThereAreOnlyTwoRowsLeftAndNoComplianceValueInTheDepartmentColumn (compliance);
        }




        [Given(@"I navigate to the ""([^""]*)"" category and ""([^""]*)"" section")]
        public void GivenINavigateToTheElementsCategoryAndButtonsSection(string elements, string buttons)
        {
            driverHelper.INavigateToTheElementsCategoryAndButtonsSection (elements, buttons);
        }

        [When(@"I perform (.*) on the (.*) button")]
        public void WhenIPerformActionsOnButtons(string action0, string buttonName)
        {
           driverHelper.IPerformActionsOnButtons (action0, buttonName);
        }

        [Then(@"I verify that the respective message appears")]
        public void ThenIVerifyThatTheRespectiveMessageAppears()
        {
            driverHelper.IVerifyThatTheRespectiveMessageAppears();
        }
    }
   
} */