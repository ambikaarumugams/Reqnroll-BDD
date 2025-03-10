Feature: TMFeature

As a Turnup Portal admin user
I would like to create,edit and delete time and material records
So that I can manage the employee time and materials record successfully

Background:
	Given user logged in to the Turnup Portal successfully with valid username "hari" and password "123123"
	And navigate to time and materials page

@Regression
Scenario: Create new time and material record with valid data
	When creating a new time and material record
	Then the record should be created successfully

Scenario Outline: Edit existing time record with valid data
	When editing the "<code>" and "<description >" textbox
	Then the record should have the updated "<code>" and "<description>"

Examples:
	| code  | description |
	| A_002 | Test        |
	| A_010 | BDD         |
	| A_012 | Time Record |

	Scenario: Delete existing time record
	When deleting the last record
	Then the record should be deleted 

	