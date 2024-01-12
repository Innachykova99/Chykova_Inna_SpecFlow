Feature: Interaction with Elements

 As a user,
  I want to interact with various elements available under the Elements category
  In order to perform specific actions and verify their functionality

Background: I am on https://demoqa.com/ homepage

    Scenario Outline: Verify all entered data in the table after form submission
    When I navigate to the "Elements" category and "Text Box" section 
    And I complete the form with <Full Name> and <Email> and <Current Address> and <Permanent Address> 
    And I click on "Submit"
    Then I verify that <Full Name> and <Email> and <Current Address> and <Permanent Address> match the table content

    Examples:
    | Full Name    | Email             | Current Address         | Permanent Address |
    | Inna Chykova | innac@example.com | 7 Cherednichenkivsky St | 662 Svobody Ave   | 
    
    
    Scenario: Select specific items from various folders
    Given I navigate to the the category named "Elements" and "Check Box" section
    And I expand the folder named "Home"
    And I select the "Desktop" folder without expanding it
    And I expand the "Documents" folder and "WorkSpace" folder
    And I select "Angular" and "Veu" from the "WorkSpace" folder
    And I expand the "Office" folder
    When I click on each element in the "Office" folder one by one
    And I expand the "Downloads" folder
    And I select the entire "Downloads" folder
    Then I verify that the output contains "You have selected: desktop notes commands angular veu office public private classified general downloads wordFile excelFile"

    Scenario: Verify sorting and deletion in Web Tables
    Given I navigate to the "Elements" category and section named "Web Tables"
    When I click on the Salary column header
    Then I verify that the Salary column values are in ascending order
    And I delete the second row from the table
    Then I check that there are only two rows left and no "Compliance" value in the Department column

    Scenario Outline: Verifying different button actions
    And I navigate to the "Elements" category and "Buttons" section
    When I perform <action> on the <button_name> button
    Then I verify that the respective message appears

Examples:
    | Action         | Button Name        |
    | single click   | Click Me           |
    | double click   | Double Click Me    |
    | right click    | Right Click Me     |

   