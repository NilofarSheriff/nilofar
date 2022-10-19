Feature: Product

A short summary of the feature

@tag1
Scenario: Add to Cart
	Given the Product Id as 1
	And the qty 5
	When they added to list
	Then Product list should be added 1
