Feature: ComputerPlayOrder
	As a player
	I want to start a game against the computer
	So that I can play even when I don't have friends

@computer
Scenario: Computer starts
	Given there is a computer controller character
	When the game is started
	Then the computer should roll for it's turn order

@computer
Scenario: Computer rolls dice
	Given there is a computer controller character
	When it is that character's turn
	Then they should roll the dice and move their token