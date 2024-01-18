Feature: 1.1.Interaction with Elements

 As a user,
  I want to interact with various elements available under the Elements category
  In order to perform specific actions and verify their functionality

Background:
	Given User is on "https://demoqa.com/" homepage

Scenario Outline: 1.1.1.Verify all entered data in the table after form submission
	Given User navigates to "Elements" category 
			When User navigates to "Text Box" section
			And User completes the form with <FullName>, <Email>, <CurrentAddress> and <PermanentAddress>
			And User clicks Submit button
			Then User verifies that <FullName> and <Email> and <CurrentAddress> and <PermanentAddress> match the table content

	Examples:
		| FullName     | Email             | CurrentAddress          | PermanentAddress |
		| Inna Chykova | innac@example.com | 7 Cherednichenkivsky St | 662 Svobody Ave  |
    
    
Scenario: 1.1.2.Select specific items from various folders
	Given User navigates to "Elements" category
	When User navigates to "Check Box" section
		And User expands the "home" folder
		And User selects the Desktop folder without expanding it
		And User expands the "documents" folder 
		And User expands the "workspace" folder
		And User selects "angular" and "veu" from the WorkSpace folder
		And User expands the "office" folder
		And User clicks on each element in the "office" folder one by one
		And User expands the "downloads" folder
		And User selects the entire Downloads folder
	Then User verifies that the output contains "You have selected : desktop notes commands angular veu office public private classified general downloads wordFile excelFile"

Scenario: 1.1.3.Verify sorting and deletion in Web Tables
	Given User navigates to "Elements" category 
	When User navigates to "Web Tables" section
		And User clicks on the Salary column header
		And User verifies that the Salary column values are in ascending order
	When User deletes the second row from the table
	Then User checks that there are only two rows left and no "Compliance" value in the Department column

Scenario Outline: 1.1.4.Verifying different button actions
	Given User navigates to "Elements" category 
	When User navigates to "Buttons" section
		And User performs <action> on the <buttonName> button
	Then User verifies that the respective <message> appears for relevant <buttonId>

Examples:
	| action       | buttonName      | message                       | buttonId            |
	| single click | Click Me        | You have done a dynamic click | dynamicClickMessage |
	| double click | Double Click Me | You have done a double click  | doubleClickMessage  |
	| right click  | Right Click Me  | You have done a right click   | rightClickMessage   |