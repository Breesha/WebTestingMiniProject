Feature: YourInfo_BDD
	In order to be able to navigate to the checkout overview
	As a standard user of the sauce demo website
	I want to be able to add my information
	So I can advance to the checkout overview

@yourinfopage
Scenario: No Fields Entered
	Given I am on the Your Information page
	And the fields are empty
	When the continue button is clicked
	Then the error message will say "Error: First Name is required"

@yourinfopage
Scenario Outline: Not All Fields Entered
	Given I am on the Your Information page
	And the <first name>, <last name> and <postal code> are entered
	When the continue button is clicked
	Then the following error message will say <error message>
	Examples:
	| first name | last name | postal code | error message                  |
	| Breesha    |           |             | Error: Last Name is required   |
	|            | Foxton    |             | Error: First Name is required  |
	|            |           | IM2         | Error: First Name is required  |
	| Breesha    | Foxton    |             | Error: Postal Code is required |
	|            | Foxton    | IM2         | Error: First Name is required  |
	| Breesha    |           | IM2         | Error: Last Name is required   |
	
@yourinfopage
Scenario: Cancel the login
	Given I am on the Your Information page
	And the fields are empty
	When the cancel button is clicked
	Then the page url will be "https://www.saucedemo.com/cart.html"

@yourinfopage
Scenario Outline: Valid login
	Given I am on the Your Information page
	And the <first name>, <last name> and <postal code> are entered
	When the continue button is clicked
	Then the page url will be "https://www.saucedemo.com/checkout-step-two.html"
	Examples:
	| first name | last name | postal code |
	| Breesha    | Foxton    | IM2         |