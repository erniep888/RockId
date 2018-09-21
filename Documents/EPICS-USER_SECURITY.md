# RockId Epics - User Security #
## Description ##
All users must be known to the system. Therefore, each user will login with a username and password.
## Solution ##
* Anonymous user access is denied.
* All users must login in with an email address
* All users have a password that is 8 to 32 characters long and alphanumeric with special characters.
## Epics -> Stories ##
* Epic #1 : (20) : System must support adding and removing users
	* Story #1 : (5) : As a new user, I need a way to create an account.
	* Story #2 : (2) : As an admin, I need a way to be identified differently in the system.
	* Story #3 : (2) : As an admin, I need a way to remove a user.
	* Story #4 : (2) : As an admin, I need a way to add a user.
* Epic #2 : (8) : System must support user login
	* Story #5 : (3) : As a system user, I need a way to login.
	* Story #6 : (5) : As a developer, I need to investigate the best implementation strategy for user login.  Provide an implementation plan.
	* Story #32 : (2) : As a user, I want to see my name in the upper right-hand corner of the screen once I am logged in.
## Wireframes ##
![Login](https://github.com/erniep888/RockId/blob/master/Documents/wireframe-png/Login.png?raw=true)
![Dashboard](https://github.com/erniep888/RockId/blob/master/Documents/wireframe-png/Dashboard.png?raw=true)