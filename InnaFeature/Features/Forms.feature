Feature: Forms Category

Background: 
Given User is on the "https://demoqa.com/" homepage

Scenario: Filling out the Practice Form
    Given User navigates to the category named "Forms" 
    When User navigates to the "Practice Form" section
        And User fills out the text fields with data from the table
        | FirstName | LastName | Email             | Mobile     | CurrentAddress  |
        | Inna      | Chykova  | innac@example.com | 1234567890 | 123 Svobody Ave |
    
        And User selects "Female" for Gender
        And User fills out the Date of Birth form with "07 Oct 2013"
        And User enters "Physics" and "Math" in Subjects field
        And User selects "Reading" and "Music" checkboxes for "Hobbies" 
        And User selects "Uttar Pradesh" for "State" dropdown and "Merrut" for "City" dropdown
        And User submits the form
    Then User verifies the data in the modal matches the input data
    | FirstName | LastName | Email             | Mobile     | CurrentAddress  | Gender | DateOfBirth | Subjects      | Hobbies        | StateAndCity          |
    | Inna      | Chykova  | innac@example.com | 1234567890 | 123 Svobody Ave | Female | 07 Oct 2013 | Physics, Math | Reading, Music | Uttar Pradesh, Merrut |