Feature: Navigate to Login
Navigate from startpage to login

    Scenario: Navigate to Login-page
        Given I am on the FormBridge homepage
        And I see the Sign in-button
        When I click on Sign in
        Then I am redirected to a Login-page