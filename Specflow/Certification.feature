Feature: Certification

A short summary of the feature


	Scenario: Adding Certifications to the profile page
	Given I logged into the Turnup portal successfully
	When I added certifications and save it
	Then the certifications should be saved successfully

	Scenario: Editing Certifications in the profile page
	Given I logged into the Turnup portal successfully
	When I edited certifications and save it
	Then the edited certifications should be saved successfully


Scenario: Deleting Certifications from the profile page
	Given I logged into the Turnup portal successfully
	When I  Removing certifications and save it
	Then the Certifications should be removed successfully

