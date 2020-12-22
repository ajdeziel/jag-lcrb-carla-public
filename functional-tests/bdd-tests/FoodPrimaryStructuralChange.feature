﻿Feature: FoodPrimaryStructuralChange
    As a logged in business user
    I want to submit a structural change application for a Food Primary licence

@foodprimarystructuralchange @privatecorporation
Scenario: Private Corporation Food Primary Structural Change
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Food Primary
    And I review the account profile for a private corporation
    And I complete the Food Primary application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    # And I pay the licensing fee 
    And I click on the link for Structural Change Aplication
    And I submit a Food Primary structural change application
    And I click on the link for Dashboard
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page