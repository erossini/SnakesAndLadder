Feature: FollowingPlayOrder
	As a player
	I want to follow the play order
	So that the game is more fair

@players
Scenario: Player 1 turns
	Given it is Player 1's turn
	When they have moved their token
	Then it is Player 2's turn

@players
Scenario: Player 2 turns
	Given it is Player 2's turn
	When they have moved their token
	Then it is Player 1's turn