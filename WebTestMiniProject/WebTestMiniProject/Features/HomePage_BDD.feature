Feature: HomePage_BDD
	In order to be able to buy items
	As a registered user of the saucedemo website
	I want to be able to update my cart

@Inventory
Scenario: AddItemToCartNumberItemsIncreases
	Given I am on the home page
	And I have no items in my cart
	When I add an item to my cart
	Then I should have 1 item in the cart

@Inventory
Scenario: AddItemToCartIsInCart
	Given I am on the home page
	And I have no items in my cart
	When I add an item to my cart
	And I go to the cart page
	Then There should be an item in the cart

@Inventory
Scenario: AddItemToCartButtonChanges
	Given I am on the home page
	When I add an item to my cart
	Then The button text should have changed to "REMOVE"