# Web Testing Mini Project
## Project Aim

The goal of this project is to look at the functionality for the website saucedemo.com, derive user stories from this and create some test cases for said user stories.

The functionality we are focusing on includes:

* Sign in and authentication
* Updating cart
* Check in to cart and authentication
* Finalising orders
* Product information

## Preparation

Instead of starting with a sprint, we took the first day to organise in our group how we could split the work evenly and cover the content for this project to be a success.

The project board was created to allow us to collaboratively understand each other's user stories and scenarios, so there was no repeated work or gaps in the project. The project board also let us plan out our time to complete the project in time.

The skeleton of the project was created so that each of us had the same starting point for when we begin to complete our user stories. This helps with any initial merge conflicts.

# Sprint 1 

### Sprint Aim

The aim of this sprint is to complete the coding for the project. This includes completing tests for each user story that cover the functionality as discussed in the preparation step.

### Sprint Goals

User Story 1: Sign in and authentication

- [x] Scenario 1.1 - Invalid user
- [x] Scenario 1.2 - Invalid password
- [x] Scenario 1.3 - Standard user
- [x] Scenario 1.4 - Locked out user
- [x] Scenario 1.5 - Problem user
- [x] Scenario 1.6 - Performance glitch user

User Story 2: Updating cart

- [x] Scenario 2.1 - Add Item to Cart
- [x] Scenario 2.2 - Cart Increased by 1 when Item Added to Cart
- [x] Scenario 2.3 - Button Name Change

User Story 3: Check in to cart and authentication

- [x] Scenario 3.1 - No fields entered
- [x] Scenario 3.2 - Not all fields entered
- [x] Scenario 3.3 - Cancel the login
- [x] Scenario 3.4 - Valid login

User Story 4: Checkout

- [x] Scenario 4.1 - Continue Shopping Button
- [x] Scenario 4.2 - Checkout with no Items
- [x] Scenario 4.3 - Checkout with Items
- [x] Scenario 4.4 - Remove Item from Cart

User Story 5: Item description

- [x] Scenario 5.1 - Single Item Description Page
- [x] Scenario 5.2 - Back Button
- [x] Scenario 5.3 - Add to cart
- [x] Scenario 5.4 - Add to cart: Button Title
- [x] Scenario 5.5 - Remove From Cart

### Review

For the first sprint, the aim was to complete all of the coding for the project. We achieved this as a group, mainly due to the preparation that we did yesterday. The prep meant that we could quickly get started and knew that there were no conflicting or repeated areas of work within the project and also meant we could evenly split up the work so we each have a manageable work load for the day. Tests were achieved for each user story - all of which passed.

### Retrospective

The main barrier for this sprint was that two members of the team needed time for interview prep. With this added into the plan during the prep stage of this project, there was no conflict.

As a group we always had a call going which we would all be part of. This meant that we could discuss if we had any problems and help resolve them together. It was also really useful when it came to merging our work as there was always someone available to review and approve the request. The share screen function let us review merge conflicts as a group and alter the files together.

# Sprint 2

### Sprint Aim

For the final sprint, the aim is to complete all documentation and to prepare for the presentation.

### Sprint Goals

- [ ] Update README
- [ ] Update project board
- [ ] Presentation preparation



# The Framework

### Class Diagram

![image](https://github.com/Dragonkid1996/WebTestingMiniProject/blob/main/Project%20Images/ClassDiagram.png)

### Git Branches

![image](https://github.com/Dragonkid1996/WebTestingMiniProject/blob/main/Project%20Images/Git%20Branches.png)

# Testing

![image](https://github.com/Dragonkid1996/WebTestingMiniProject/blob/main/Project%20Images/TestExplorer.png)

# Features Documentation

# Contents

# Cart\_BDD

In order to be able to complete the order

As a registered user of the saucedemo website

I want to navigate the cart page

## ContinueShoppingFromCart

_(Tags: @Cart)_

**Given** I am on the cart page

**When** I press the continue shopping button

**Then** I should land on the &quot;inventory&quot; page

## CheckoutNoItems

_(Tags: @Cart)_

**Given** I am on the cart page

**And** I have no items in my cart

**When** I press the checkout button

**Then** I should land on the &quot;checkout-step-one&quot; page

## CheckoutWithItems

_(Tags: @Cart)_

**Given** I am on the cart page with items

**And** I have items in my cart

**When** I press the checkout button

**Then** I should land on the &quot;checkout-step-one&quot; page

## RemoveItemFromCart

_(Tags: @Cart)_

**Given** I am on the cart page with items

**And** I have items in my cart

**When** I press the remove button

**Then** The item should be removed

# HomePage\_BDD

In order to be able to buy items

As a registered user of the saucedemo website

I want to be able to update my cart

## AddItemToCartNumberItemsIncreases

_(Tags: @Inventory)_

**Given** I am on the home page

**And** I have no items in my cart

**When** I add an item to my cart

**Then** I should have 1 item in the cart

## AddItemToCartIsInCart

_(Tags: @Inventory)_

**Given** I am on the home page

**And** I have no items in my cart

**When** I add an item to my cart

**And** I go to the cart page

**Then** There should be an item in the cart

## AddItemToCartButtonChanges

_(Tags: @Inventory)_

**Given** I am on the home page

**When** I add an item to my cart

**Then** The button text should have changed to &quot;REMOVE&quot;

# SD\_Login

In order to be able to use the website

As a user of the sauce demo website

I want to be able to log in

## Invalid Username

_(Tags: @mytag)_

**Given** I am on the login page

**When** I enter an username &quot;lauren&quot;

**And** I enter a password &quot;secret\_sauce&quot;

**And** I click the login button

**Then** I should see an error message containing &quot;Epic sadface: Username and password do not match any user in this service&quot;

## Invalid Password

_(Tags: @mytag)_

**Given** I am on the login page

**When** I enter an username &quot;standard\_user&quot;

**And** I enter a password &quot;1234&quot;

**And** I click the login button

**Then** I should see an error message containing &quot;Epic sadface: Username and password do not match any user in this service&quot;

## Standard User

_(Tags: @mytag)_

**Given** I am on the login page

**When** I enter an username &quot;standard\_user&quot;

**And** I enter a password &quot;secret\_sauce&quot;

**And** I click the login button

**Then** I should land on the products page where the url is &quot;https://www.saucedemo.com/inventory.html&quot;

## Locked Out User

_(Tags: @mytag)_

**Given** I am on the login page

**When** I enter an username &quot;locked\_out\_user&quot;

**And** I enter a password &quot;secret\_sauce&quot;

**And** I click the login button

**Then** I should see an error message containing &quot;Epic sadface: Sorry, this user has been locked out&quot;

## Performance Glitch User

_(Tags: @mytag)_

**Given** I am on the login page

**When** I enter an username &quot;performance\_glitch\_user&quot;

**And** I enter a password &quot;secret\_sauce&quot;

**Then** I click on the login button and should land on the products page after 3 seconds

## Problem User

_(Tags: @mytag)_

**Given** I am on the login page

**When** I enter an username &quot;problem\_user&quot;

**And** I enter a password &quot;secret\_sauce&quot;

**And** I click the login button

**And** I click the backpack label link

**Then** I should land on the item page where the url is &quot;https://www.saucedemo.com/inventory-item.html?id=5&quot;

# SingleInventoryItemDetails

Single Item Description

As standard logged in user

I want to click to a specific item

so that i can view its details

## VisitingAnInventoryItemsDetails

_(Tags: @mytag)_

**Given** I am Logged in as a Standard

**When** I click on the inventory item with the \&lt;id\&gt;

**Then** I can see that items \&lt;id\&gt; details

### Examples:

| id |
| --- |
| item\_0\_title\_link |
| item\_1\_title\_link |
| item\_2\_title\_link |
| item\_3\_title\_link |
| item\_4\_title\_link |
| item\_5\_title\_link |

## GoingFromTheSingleItemDescriptionPageBackToProductList

_(Tags: @mytag)_

**Given** I am Logged in as a Standard

**And** I am on an item&#39;s \&lt;id\&gt; description page

**When** I click the &quot;Back&quot; button

**Then** I am redirected to the products page

### Examples:

| id |
| --- |
| item\_0\_title\_link |
| item\_1\_title\_link |
| item\_2\_title\_link |
| item\_3\_title\_link |
| item\_4\_title\_link |
| item\_5\_title\_link |

## PressingTheCartButtonFromTheSingleItemDescriptionPage

_(Tags: @mytag)_

**Given** I am Logged in as a Standard

**And** I am on an item&#39;s \&lt;id\&gt; description page

**When** I click the Add to Cart button

**Then** the item amount in my cart increases by 1

### Examples:

| id |
| --- |
| item\_0\_title\_link |

## CartButtonTextChanges

_(Tags: @mytag)_

**Given** I am Logged in as a Standard

**And** I am on an item&#39;s \&lt;id\&gt; description page

**When** I click the Add to Cart button

**Then** Then the &quot;Add to cart&quot; buttons name is &quot;REMOVE&quot;

### Examples:

| id |
| --- |
| item\_0\_title\_link |

## RemoveFromCart

_(Tags: @mytag)_

**Given** I am Logged in as a Standard

**And** I am on an item&#39;s \&lt;id\&gt; description page

**And** I add an item in my cart

**When** I click the REMOVE button

**Then** the item amount in my cart decreases by 1

### Examples:

| id |
| --- |
| item\_0\_title\_link |

# YourInfo\_BDD

In order to be able to navigate to the checkout overview

As a standard user of the sauce demo website

I want to be able to add my information

So I can advance to the checkout overview

## No Fields Entered

_(Tags: @yourinfopage)_

**Given** I am on the Your Information page

**And** the fields are empty

**When** the continue button is clicked

**Then** the error message will say &quot;Error: First Name is required&quot;

## Not All Fields Entered

_(Tags: @yourinfopage)_

**Given** I am on the Your Information page

**And** the \&lt;first name\&gt;, \&lt;last name\&gt; and \&lt;postal code\&gt; are entered

**When** the continue button is clicked

**Then** the following error message will say \&lt;error message\&gt;

### Examples:

| first name | last name | postal code | error message |
| --- | --- | --- | --- |
| Breesha | | | Error: Last Name is required |
| | Foxton | | Error: First Name is required |
| | | IM2 | Error: First Name is required |
| Breesha | Foxton | | Error: Postal Code is required |
| | Foxton | IM2 | Error: First Name is required |
| Breesha | | IM2 | Error: Last Name is required |

## Cancel the login

_(Tags: @yourinfopage)_

**Given** I am on the Your Information page

**And** the fields are empty

**When** the cancel button is clicked

**Then** the page url will be &quot;https://www.saucedemo.com/cart.html&quot;

## Valid login

_(Tags: @yourinfopage)_

**Given** I am on the Your Information page

**And** the \&lt;first name\&gt;, \&lt;last name\&gt; and \&lt;postal code\&gt; are entered

**When** the continue button is clicked

**Then** the page url will be &quot;https://www.saucedemo.com/checkout-step-two.html&quot;

### Examples:

| first name | last name | postal code |
| --- | --- | --- |
| Breesha | Foxton | IM2 |

