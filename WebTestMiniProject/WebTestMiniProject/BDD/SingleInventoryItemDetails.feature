Feature: SingleInventoryItemDetails
	Simple calculator for adding two numbers

@mytag
Scenario: VisitingAnInventoryItemsDetails
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