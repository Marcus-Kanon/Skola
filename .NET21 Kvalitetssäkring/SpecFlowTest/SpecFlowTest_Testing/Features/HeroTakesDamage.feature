Feature: Return if Hero is alive
As the game engine of the game
I want to know the health of the hero
So that I can tell if they are dead or alive

Scenario: Hero has a health above 0
	Given The health is 30
	When The method is called
	Then Hero is alive

Scenario: Hero has a health of 0 or below
	Given The health is less than 1
	When The method is called
	Then Hero is dead
