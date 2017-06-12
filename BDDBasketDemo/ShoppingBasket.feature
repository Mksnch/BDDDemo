Feature: ShoppingBasket
	A simple shopping basket that we can add and remove items from

@mytag
Scenario: A new basket no content
	When I create a new basket
	Then the basket has no content
