Feature: SingleInventoryItemDetails
	Single Item Description
	As standard logged in user 
	I want to click to a specific item 
	so that i can view its details

@mytag
Scenario Outline: VisitingAnInventoryItemsDetails
	Given I am Logged in as a Standard 
	When I click on the inventory item with the <id>
	Then I can see that items <id> details
	Examples: 
	| id                |
	| item_0_title_link |
	| item_1_title_link |
	| item_2_title_link |
	| item_3_title_link |
	| item_4_title_link |
	| item_5_title_link |

	@mytag
Scenario Outline: GoingFromTheSingleItemDescriptionPageBackToProductList
Given I am Logged in as a Standard 
And I am on an item's <id> description page
When I click the "Back" button
Then I am redirected to the products page
	Examples: 
	| id                |
	| item_0_title_link |
	| item_1_title_link |
	| item_2_title_link |
	| item_3_title_link |
	| item_4_title_link |
	| item_5_title_link |

	@mytag
Scenario Outline: PressingTheCartButtonFromTheSingleItemDescriptionPage
Given I am Logged in as a Standard 
And I am on an item's <id> description page
When I click the Add to Cart button
Then the item amount in my cart increases by 1
Examples: 
| id                |
| item_0_title_link |

@mytag
Scenario Outline: CartButtonTextChanges
Given I am Logged in as a Standard
And I am on an item's <id> description page
When I click the Add to Cart button
Then Then the "Add to cart" buttons name is "REMOVE"
Examples: 
| id                |
| item_0_title_link |

@mytag
Scenario Outline: RemoveFromCart
Given I am Logged in as a Standard
And I am on an item's <id> description page
And I add an item in my cart
When I click the REMOVE button
Then the item amount in my cart decreases by 1
Examples: 
| id                |
| item_0_title_link |
