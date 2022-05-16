#Feature: Login
#	Check if login functionality works
#
#@smoke @positive
#Scenario: Login user as Administrator
#	Given I navigate to application
#	And I see application opened
#	Then I click login link
#	When I enter username and password
#		| UserName | Password |
#		| admin    | password |
#	Then I click login button
#	Then I should see the username with hello
#
#@smoke @positive
#Scenario: Login user as Administrator - Take screeshot
#	Given I navigate to application
#	And I see application opened
#	Then I click login link
#	When I enter username and password
#		| UserName | Password |
#		| admin    | password |
#	Then I click login button
#	Then I should see the username with hello