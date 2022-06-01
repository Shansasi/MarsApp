Feature: Language

As a seller I should be able to add my language details as profile details  so that people seeking for some skills can look into my details.

Scenario: Adding a language to the profile page
	Given I logged into the Turnup portal successfully
	When I adding '<Language>', and level in the profile page and save it
	Then then '<Language>' and level should be saved successfully
	Examples: 
	| Language |    
	| English  |  
	

	Scenario: Editing a language in the profile page
	Given I logged into the Turnup portal successfully
	When I editing '<Language>' and level and save it
	Then the edited '<Language>' and level should be saved successfully
	Examples: 
	| Language |  
	| Tamil  |    

	Scenario: Deleting a language in the profile page
	Given I logged into the Turnup portal successfully	
	When I  Removing language and save it
	Then the language should be removed successfully