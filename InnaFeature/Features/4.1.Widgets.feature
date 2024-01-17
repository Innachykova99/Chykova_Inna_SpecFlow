Feature: 4.1.Widgets

Background:
	Given User is on "https://demoqa.com/" homepage

Scenario: 4.1.1.Testing Auto Complete functionality
   
	Given User navigates to "Widgets" category
	When User navigates to "Auto Complete" section
		And User types letter "g" in the Type multiple color names field
	Then User verifies that three autocomplete suggestions contain the letter 'g'

Scenario: 4.1.2.Testing selecting and deleting colors
	Given User navigates to "Widgets" category
	When User navigates to "Auto Complete" section
		And User adds the colors Red, Yellow, Green, Blue, and Purple to the Type multiple color names field
		And User removes "Yellow" and "Purple"
	Then User verifies only Red, Green, and Blue remain in the field

Scenario: 4.1.3.Testing Progress Bar
	Given User navigates to "Widgets" category
	When User navigates to the "Progress Bar" section
		And User clicks Start and wait until the progress reaches 100%
		And User verifies that the button changes to Reset
	When User clicks Reset
	Then User verifies that the button changes back to Start and the progress is at 0%