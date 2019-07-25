Feature: CarRentFeature

Scenario: url is working
	Given chrome instance is open
	When set the url
	Then car rent logo is displayed

Scenario: search label is displayed
	Given chrome instance is open
	When set the url
	Then 'Search' label is displayed

Scenario: age checkbox is enabled
	Given chrome instance is open
	When set the url
	Then age checkbox is enabled
	And  the label is 'Age over 21 years!'

Scenario: the car's brand is displayed
	Given chrome instance is open
	When set the url
	Then the brand is displayed
	And the first car is 'AUDI '
	And the second car is 'MERCEDES'
	And the last one is 'TOYOTA'



	