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

Scenario: tabs are displayed
	Given chrome instance is open
	When set the url
	Then the below tabs are available
	| tabs          |
	#| Home          |
	| View all cars |
	| Contact       |

Scenario: car-list is working
	Given chrome instance is open
	When set the url for car-list
	Then car rent logo is displayed for car-list

Scenario: imagine is working
	Given chrome instance is open
	When set the url for car-list
	Then car photo is displayed for car-list


Scenario: button is working
	Given chrome instance is open
	When set the url for car-list
	Then button is visible

Scenario: link to rent! is working
	Given chrome instance is open
	When set the url for car-list
	Then link to rent
	