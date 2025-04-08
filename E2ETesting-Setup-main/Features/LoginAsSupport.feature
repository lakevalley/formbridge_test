Feature: Login as Support

    Scenario: Login as Support
        Given I am on the Login page
        And I have entered my credentials
        When I click the login button
        Then I am redirected to the support dashboard