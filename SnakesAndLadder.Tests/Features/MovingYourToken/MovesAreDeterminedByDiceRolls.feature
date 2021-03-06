﻿Feature: MovesAreDeterminedByDiceRolls
	As a player
	I want to move my token based on the roll of a die
	So that there is an element of chance in the game

@dice
Scenario: ResultBetween1And6
	Given the game is started
	When the player rolls a die
	Then the result should be between 1 and 6 inclusive

@dice
Scenario: ResultAndMove
	Given the player rolls a 4
	When they move their token
	Then the token should move 4 spaces