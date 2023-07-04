Feature: GrabPageTitle

Scenario: Grab page title and place in answer slot #1
	When the page title is grabbed
	Then the title text is placed in answer slot
