Feature: Add user
    
    Scenario: Add user
        Given I am on the Admin dashboard
        When I click on the Add User button
        And I fill out the user fields
        And I click the Add User button
        Then the new user is saved