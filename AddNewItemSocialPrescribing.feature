Feature: AddNewItemSocialPrescribing
	As a logged user
	I want to create a new item on Social Prescribing list
	

@AddNewItemSocialPrescribing
Scenario: Add a new Social Prescribing item to the list
	Given I navigate to Social Prescribing link
	When I click on Create a new item, fill the form and save
	Then the new item should be added to the list
