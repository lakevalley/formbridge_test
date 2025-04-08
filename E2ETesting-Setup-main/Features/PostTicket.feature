Feature: Post Ticket as customer
    
    Scenario: Post Ticket as customer
        Given I am on the Inet Form page
        And I fill out the form
        When I click the Submit button
        Then I am redirected to the HomePage