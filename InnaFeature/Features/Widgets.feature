Feature: Widgets

Background:
	Given User is on the "https://demoqa.com/" homepage

Scenario: Testing Auto Complete functionality
   
	Given User navigates to "Widgets" category
	When User navigates to "Auto Complete" section
		And User types letter "g" in the Type multiple color names field
	Then User verifies that three autocomplete suggestions contain the letter 'g'

Scenario: Testing selecting and deleting colors
	Given User goes to the "Widgets" category
	When User navigates to "Auto Complete" section
		And User adds the colors Red, Yellow, Green, Blue, and Purple to the "Type multiple color names" field
		And User removes "Yellow" and "Purple"
	Then User verifies only Red, Green, and Blue remain in the field

Scenario: Testing Progress Bar
	Given User navigates to category "Widgets"
	When User navigates to "Progress Bar" section
		And User clicks Start and wait until the progress reaches 100%
	Then User verifies that the button changes to Reset
	When User clicks Reset
	Then User verifies that the button changes back to Start and the progress is at 0%