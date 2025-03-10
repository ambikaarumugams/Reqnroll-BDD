Feature: Login

 As a Turnup Portal admin user
 I would like to login with valid data
 So that I can login successfully 

@Regression @Login
Scenario: Successful login with valid data
	Given User launch the Chrome browser
	When User opens the url "http://horse.industryconnect.io/"
	And Enter the valid username "hari" and password "123123"
	And Click the Login button
	Then User should be logged in successfully
#
#Scenario: Login with invalid data should be unsuccessful
#	Given User launch the Chrome browser
#	When User opens the url "http://horse.industryconnect.io/"
#	And Enter the valid username "Hari" and password "123123"
#	And Click the Login button
#	Then User login should fail
