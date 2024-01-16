Feature: Interaction with Elements

 As a user,
  I want to interact with various elements available under the Elements category
  In order to perform specific actions and verify their functionality

Background:
	Given User is on the "https://demoqa.com/" homepage

Scenario Outline: Verify all entered data in the table after form submission
	When User navigates to the "Elements" category 
		And User navigates to the "Text Box" section
		And User completes the form with <FullName> and <Email> and <CurrentAddress> and <PermanentAddress>
		And User clicks on "Submit"
		Then User verifies that <FullName> and <Email> and <CurrentAddress> and <PermanentAddress> match the table content

Examples:
	| FullName     | Email             | CurrentAddress          | PermanentAddress |
	| Inna Chykova | innac@example.com | 7 Cherednichenkivsky St | 662 Svobody Ave  |
    
    
Scenario: Select specific items from various folders
	Given User navigates to the the category named "Elements" 
	When User navigates to the "Check Box" section
		And User expands the folder named "Home"
		And User selects the "Desktop" folder without expanding it
		And User expands the "Documents" folder 
		And User expands "WorkSpace" folder
		And User selects "Angular" and "Veu" from the WorkSpace folder
		And User expands the "Office" folder
		And User clicks on each element in the Office folder one by one
		And User expands the "Downloads" folder
		And User selects the entire "Downloads" folder
	Then User verifies that the output contains "You have selected: desktop notes commands angular veu office public private classified general downloads wordFile excelFile"

Scenario: Verify sorting and deletion in Web Tables
	Given User navigates to the "Elements" category 
	When User navigates to section named "Web Tables"
		And User clicks on the Salary column header
	Then User verifies that the Salary column values are in ascending order
	When User deletes the second row from the table
	Then User checks that there are only two rows left and no "Compliance" value in the Department column

Scenario Outline: Verifying different button actions
	Given User navigates to the "Elements" category 
	When User navigates to "Buttons" section
		And User performs <action> on the <buttonName> button
	Then User verifies that the respective message appears

Examples:
	| Action       | ButtonName     |
	| single click | Click Me        |
	| double click | Double Click Me |
	| right click  | Right Click Me  |

   