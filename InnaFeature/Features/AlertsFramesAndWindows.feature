﻿ Feature: Alerts Frames And Windows
 
 Background: 
 Given User is on https://demoqa.com/ homepage

Scenario: Opening a New Tab
    Given User is on the "Alerts, Frame & Windows" section
    When User clicks "Browser Window" section
        And User clicks the "New Tab" button
        And User switches to the new tab
    Then User verifies that the text "This is a sample page" is present

Scenario: Opening a New Window
    Given User is on the "Alerts, Frame & Windows" section
    When User navigates to "Browser Window" section
        And User clicks the "New Window" button
        And User switches to the new window
    Then User verifies that the text "This is a sample page" is presented



     
