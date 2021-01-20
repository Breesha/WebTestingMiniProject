Feature: SD_Login
	In order to be able to use the website 
	As a user of the sauce demo website
	I want to be able to log in

@mytag
Scenario: Invalid User
	Given I am on the login page
	When I enter an invalid username "lauren"
	And I enter a valid password "secret_sauce"
	And I click the login button
	Then I should see an error message containing "Epic sadface: Username and password do not match any user in this service"