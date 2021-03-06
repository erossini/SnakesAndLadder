﻿Feature: TokenCanMoveAcrossTheBoard
	As a player
	I want to be able to move my token
	So that I can get closer to the goal

@moveTest
Scenario: MoveFromStartTo1
	Given the game is started
	When the token is placed on the board
	Then the token is on square 1

@moveTest
Scenario: MoveFrom1To4
	Given the token is on square 1
	When the token is moved 3 spaces
	Then the token is on square 4

@moveTest
Scenario: MoveFrom1To8
	Given the token is on square 1
	When the token is moved 3 spaces
	And then it is moved 4 spaces
	Then the token is on square 8