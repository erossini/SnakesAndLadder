Feature: ComputerPlaying
	As a player
	I want to play against the computer
	So that I can play even when I don't have friends

@computer
Scenario: Computer moves its token
	Given the game is started
	When it is the computer's turn
	Then the computer should roll and move it's token