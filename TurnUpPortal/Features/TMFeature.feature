Feature: TMFeature

As a Turnup Portal admin user
I would like to create,edit and delete time and material records
So that I can manage the employee time and materials record successfully

@tag1
Scenario:Create new time and material record with valid data
	Given user logged in to the Turnup Portal successfully with valid username "hari" and password "123123"
	And  navigate to time and materials page
	When creating a new time and material record
	Then the record should be created successfully
