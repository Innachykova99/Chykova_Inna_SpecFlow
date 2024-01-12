 Feature: Alerts Frames And Windows
 
 Background: I am on https://demoqa.com/ homepage

Scenario: Opening a New Tab
    Given I am on the Alerts, Frame & Windows section
    And I click "Browser Window" section
    And I click the "New Tab" button
    When I switch to the new tab
    Then I verify that the text "This is a sample page" is present

Scenario: Opening a New Window
    Given I am on the Alerts, Frame & Windows section
    And I navigate to "Browser Window" section
    And I click the "New Window" button
    When I switch to the new window
    Then I verify that the text "This is a sample page" is presented



     
