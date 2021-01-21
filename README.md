# Web Testing Mini Project
## Project Aim

The goal of this project is to look at the functionality for the website saucedemo.com, derive user stories from this and create some test cases for said user stories.

The functionality we are focusing on includes:

* Sign in and authentication
* Updating cart
* Check in to cart and authentication
* Finalising orders
* Product information

## Class Diagram

![image](https://github.com/Dragonkid1996/WebTestingMiniProject/blob/dev/Project%20Images/ClassDiagram.png)

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

Complete work

Good work load

Good prep from yesterday

### Retrospective

Kept in mind 2 members had interviews today

Good communication with problems, always on a call/ available

Team effort to merge all our work together

# Sprint 2

### Sprint Aim

For the final sprint, the aim is to complete all documentation and to prepare for the presentation.

### Sprint Goals

- [ ] Update README
- [ ] Update project board
- [ ] Presentation preparation



# The Framework

<li class="scenario">
            <div class="scenario-heading" id="no-fields-entered">
              <p class="tags">Tags: <span>@yourinfopage</span></p>
              <h2>No Fields Entered</h2>
            </div>
            <div class="steps">
              <ul>
                <li class="step">
                  <span class="keyword">Given </span>I am on the Your Information page</li>
                <li class="step">
                  <span class="keyword">And </span>the fields are empty</li>
                <li class="step">
                  <span class="keyword">When </span>the continue button is clicked</li>
                <li class="step">
                  <span class="keyword">Then </span>the error message will say "Error: First Name is required"</li>
              </ul>
            </div>            <a class="scenario-link" href="javascript:showImageLink('no-fields-entered')" title="Copy scenario link to clipboard.">
              <i class="icon-link"> </i>
            </a>
 </li>

# Testing

![image](https://github.com/Dragonkid1996/WebTestingMiniProject/blob/dev/Project%20Images/TestExplorer.png)
