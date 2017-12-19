Feature: Checkout
	As a customer 
	I want to add items to my cart
	So I can make purchases online

@Checkout
Scenario: Add Items to Cart
	Given I am logged in
	Given I am on the Home page
	And I have added an item to the Cart 
	When I click Proceed to checkout
	Then I can view the items in my Shopping Cart

@Checkout
Scenario: Complete Order
	Given I am on the Shopping-Cart Summary page 
	And I have items in my cart
	And I have proceeded through to the Shipping page
	And I have agreed to the terms of Service
	When I confirm my method of payment
	Then I am taken to the confirmation page

