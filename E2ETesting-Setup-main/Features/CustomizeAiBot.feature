Feature: Customize AI-bot
    
    Scenario: Customize AI-bot
        Given I am on the dashboard for Admins
        When I click on the AI ChatBot button
        And I give the AI a new personality
        And I click on the AI Submit button
        Then the Current setting is updated