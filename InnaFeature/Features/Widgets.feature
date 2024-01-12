Feature: Widgets

Background: I am on the demoqa.com homepage


Scenario: Testing Auto Complete functionality
   
    Given I navigate to "Widgets" category and "Auto Complete" section
    When I type letter 'g' in the "Type multiple color names" field
    Then I verify three autocomplete suggestions contain the letter 'g'

    Scenario: Testing selecting and deleting colors
    Given I go to the "Widgets" category and "Auto Complete" section
    When I add the colors Red, Yellow, Green, Blue, and Purple to the "Type multiple color names" field
    And I remove Yellow and Purple
    Then I verify only Red, Green, and Blue remain in the field

  Scenario: Testing Progress Bar
    Given I navigate to category "Widgets" and "Progress Bar" section
    When I click Start and wait until the progress reaches 100%
    Then I verify that the button changes to Reset
    When I click Reset
    Then I verify that the button changes back to Start and the progress is at 0%