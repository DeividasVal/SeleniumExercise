Feature: AllTasks

Scenario: Complete every task from the website
	When the page title is grabbed the title text is placed in answer slot
	And name section of the form is filled out with 'Kilgore Trout'
	And user selects the drop down menu and chooses menu item 'Science Fiction Author'
	And count the number of blueboxes on the page
	And the bluebox count into answer box #4
	And user clicks on a link with the text 'click me'
	And  class applied to the red box is retrieved
	And the class applied to the red box is entered into answer box #6
	And the function ran_this_js_function() is ran
	And the function got_return_from_js_function() is ran and it's answer is put into answer box six
	And the radio button is marked to Yes for written book
	And the text from the red box is placed in answer box #10
	And check box is on top? orange or green, place correct color in answer slot eleven
	And set browser width to 850 and height to 650
	And type into answer slot thirteen yes or no depending on whether item by id of ishere is on the page
	And type into answer slot fourteen yes or no depending on whether item with id of purplebox is visible
	And do the waiting game
	And click complete after the waiting game
	Then the button check results is pressed

