Feature: Education

As a seller I should be able to add my Education details as profile details  so that people seeking for some skills can look into my details.

Scenario: Adding Education to the profile page
	Given I logged into the Turnup portal successfully
	When I added Education and save it
	Then the Education should be saved successfully

Scenario: Editing Education in the profile page
	Given I logged into the Turnup portal successfully
	When I edited Education and save it
	Then the Edited education should be saved successfully


Scenario: Deleting Education from the profile page
	Given I logged into the Turnup portal successfully
	When I  Removing Education and save it
	Then the Education should be removed successfully