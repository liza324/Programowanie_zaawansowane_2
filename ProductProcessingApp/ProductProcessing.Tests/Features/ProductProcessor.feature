Feature: Product processing
    To ensure the product is processed correctly
    As a user of the system
    I want to verify the product processing functionality

Scenario: Process a product
    Given I have a product "ProductABC" with quantity 3
    When I process the product
    Then the product should be processed with quantity 3
