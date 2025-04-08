Feature: Login as Admin

    Scenario: Login as Admin
        Given I am on the page for Login
        And I have entered my admin credentials
        When I click on the login button
        Then I am redirected to the admin dashboard