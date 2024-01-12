Feature: Forms Category

Background: I am on the demoqa.com homepage

Scenario: Filling out the Practice Form
    Given I navigate to the category named "Forms" and "Practice Form" section
    When I fill out the text fields with data from the table Examples:
        | First Name | Last Name | Email             | Mobile     | Current Address |
        | Inna       | Chykova   | innac@example.com | 1234567890 | 123 Svobody Ave |
    
    And I select "Female" for "Gender"
    And I fill out the "Date of Birth" form with "07 Oct 2013"
    And I enter "Physics" and "Math" in "Subjects" field
    And I select "Reading" and "Music" checkboxes for "Hobbies" 
    And I select "Uttar Pradesh" for "State" dropdown and "Merrut" for "City" dropdown
    And I submit the form
    Then I verify the data in the modal matches the input data
