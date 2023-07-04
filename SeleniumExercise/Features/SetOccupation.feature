Feature: SetOccupation

Scenario: Set occupation on form to Sci-Fi Author
	When the user selects the drop down menu and chooses menu item 'Science Fiction Author'
	Then the selected item should be 'Science Fiction Author'
