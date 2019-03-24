Feature: LaddersGoUpNotDown
	As a player
	I want ladders to move my token up
	So that the game is more fun

@ladder
Scenario: LadderUp
	Given there is a ladder connecting squares 2 and 12
	When the token lands on square 2
	Then the token is on square 12

@ladder
Scenario: NoMoves
	Given there is a ladder connecting squares 2 and 12
	When the token lands on square 12
	Then the token is on square 12