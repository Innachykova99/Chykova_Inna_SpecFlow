Feature: Interactions

Background: 
Given User is on "https://demoqa.com/" homepage

  Scenario: Testing Selectable interaction
    Given User navigates to "Interactions" category
    When User navigates to "Selectable" section
        And User clicks on Grid tab
        And User selects squares "One,Three,Five,Seven,Nine"
    Then User verifies the selected values are One, Three, Five, Seven, and Nine respectively