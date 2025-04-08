Feature: Logout as Support

    Scenario: Logout as Support
        Given I am on the Support dashboard page
        When I click the logout button
        Then I am redirected to the login page