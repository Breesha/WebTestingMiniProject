Feature: Cart_BDD
	In order to be able to complete the order
	As a registered user of the saucedemo website
	I want to navigate the cart page

@Cart
Scenario: ContinueShoppingFromCart
	Given I am on the cart page
	When I press the continue shopping button
	Then I should land on the "inventory" page

@Cart
Scenario: CheckoutNoItems
	Given I am on the cart page
	And I have no items in my cart
	When I press the checkout button
	Then I should land on the "checkout-step-one" page

@Cart
Scenario: CheckoutWithItems
	Given I am on the cart page with items
	And I have items in my cart
	When I press the checkout button
	Then I should land on the "checkout-step-one" page
	