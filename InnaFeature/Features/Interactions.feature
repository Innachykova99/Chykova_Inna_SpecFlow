Feature: Interactions

Background: I am on the demoqa.com homepage

  Scenario: Testing Selectable interaction

    Given I navigate to the category "Interactions" and section "Selectable"
    When I click on the "Grid" tab
    And I select squares 1, 3, 5, 7, and 9
    Then I verify the selected values are One, Three, Five, Seven, and Nine respectively