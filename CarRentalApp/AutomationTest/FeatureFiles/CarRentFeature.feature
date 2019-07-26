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

Scenario: add-car-rental-page is working
	Given chrome instance is open
	When set the url for add-car-rental-page
	Then the photo for add-car-rental-page is displayed

Scenario: photo label is displayed
	Given chrome instance is open on car rent
	When set the url
	Then 'Photo' label is displeyed 

Scenario: registration number is displayed
	Given chrome instance is open on car rent
	When set the url for add-car-rental-page
	Then 'Registration number' label is displayed for registration number

Scenario: number of doors is displayed
	Given chrome instance is open
	When set the url for add-car-rental-page
	Then 'Number of doors' label is displayed for number of doors

Scenario: the button previous is working
	Given chrome instance is open
	When set the url for add-car-rental-page
	Then the button previous is working

Scenario: tabs are displayed
	Given chrome instance is open
	When set the url
	Then the below tabs are available
	| tabs  |
	| Month |
	| Week  |
	| Day   |

Scenario: first name checkbox is enabled
	Given chrome instance is open
	When set the url
	Then first name checkbox is enabled
	   And  and label is 'First Name:'

#Scenario: user info tabs are displayed
#	Given chrome instance is open
#	When set the url
#	Then the user info tabs are available
	