Feature: Skills

As a seller I should be able to add my skills details as profile details  so that people seeking for some skills can look into my details.

Scenario: Adding skills to the profile page
	Given I logged into the Turnup portal successfully
	When I added skills and save it
	Then the skills should be saved successfully

Scenario: Editing skills in the profile page
	Given I logged into the Turnup portal successfully
	When I edited skills and save it
	Then the edited skills should be saved successfully


Scenario: Deleting a skills in the profile page
	Given I logged into the Turnup portal successfully
	When I  Removing language and save it
	Then the skills should be removed successfully