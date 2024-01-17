 Feature: 3.1.Alerts, Frames and Windows
 
 Background: 
 Given User is on "https://demoqa.com/" homepage

Scenario: 3.1.1.Opening a New Tab
    Given User is on the "Alerts, Frame & Windows" category
    When User clicks "Browser Window" section
        And User clicks the New Tab button
        And User switches to the new tab
    Then User verifies that the text This is a sample page is presented

Scenario: 3.1.2.Opening a New Window
    Given User is on the "Alerts, Frame & Windows" category
    When User navigates to "Browser Window" section
        And User clicks the New Window button
        And User switches to the new window
    Then User verifies that the text This is a sample page is presented