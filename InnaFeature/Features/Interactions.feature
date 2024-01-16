Feature: Interactions

Background: 
Given User is on the "https://demoqa.com/" homepage

  Scenario: Testing Selectable interaction
    Given User navigates to the category "Interactions" 
    When User navigates to section "Selectable"
        And User clicks on the "Grid" tab
        And User selects squares 1, 3, 5, 7, and 9
    Then User verifies the selected values are One, Three, Five, Seven, and Nine respectively