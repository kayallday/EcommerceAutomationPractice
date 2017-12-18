Feature: Login
	As a user 
	I want to login
	So I can purchase items in the store


@Login
Scenario: Login with valid Credentials 
	Given I am on the Login Page
	And I enter valid credentials
	When I click the Sign in button
	Then Can view the My Account page
