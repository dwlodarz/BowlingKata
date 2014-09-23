Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
@list
Scenario Outline: Add two numbers
	Given North Star demo app at http://10.50.1.83:8080/datadepot-web
	When I go to Environment module
	Then <subModule> is present
	Examples: 
	| subModule                 |
	| Log View                  |
	| Environment Management    |
	| Environment Configuration |
	| Service Discovery         |
	| Environment Setup         |
