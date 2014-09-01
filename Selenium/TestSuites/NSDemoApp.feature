Feature: SeleniumKata
	In order to test NorthStar demo App
	I want to run few tests against it

Scenario: Check if environment can be displayed
	Given North Star demo app at http://10.50.1.83:8080/datadepot-web
	When I go to Environment module
	And I open Environment Management
	Then list of running environments will be displayed
