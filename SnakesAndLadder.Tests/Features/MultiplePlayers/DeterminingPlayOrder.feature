Feature: DeterminingPlayOrder
	As a player
	I want to influence the play order
	So that player 1 doesn't always go first

@players
Scenario: Add players
	Given there are two players
	When the game is started
	Then the players must roll dice to determine their play order

@players
Scenario: Player order
	Given the players are rolling to determine play order
	When Player 1 rolls higher than Player 2
    Then Player 1 rolls first

@players
Scenario: Player order by rolling
	Given the players are rolling to determine play order
	When Player 2 rolls higher than Player 1
	Then Player 2 rolls first

@players
Scenario: Player rolling the same
	Given the players are rolling to determine play order
	When Player 1 rolls the same as Player 2
	Then the players must roll again