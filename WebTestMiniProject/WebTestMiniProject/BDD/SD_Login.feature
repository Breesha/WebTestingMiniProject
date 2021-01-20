Feature: SD_Login
	In order to be able to use the website 
	As a user of the sauce demo website
	I want to be able to log in

@mytag
Scenario: Invalid Username
	Given I am on the login page
	When I enter an username "lauren"
	And I enter a password "secret_sauce"
	And I click the login button
	Then I should see an error message containing "Epic sadface: Username and password do not match any user in this service"

	@mytag
Scenario: Invalid Password
	Given I am on the login page
	When I enter an username "standard_user"
	And I enter a password "1234"
	And I click the login button
	Then I should see an error message containing "Epic sadface: Username and password do not match any user in this service"

		@mytag
Scenario: Standard User
	Given I am on the login page
	When I enter an username "standard_user"
	And I enter a password "secret_sauce"
	And I click the login button
	Then I should land on the products page where the url is "https://www.saucedemo.com/inventory.html"