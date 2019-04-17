# Mobile Applications Development Project
# Sean O'Gorman - G00314259
# Seas of Wrath 

Created using Visual Studio 2017 ver. 15.9.10


HOW THE GAME FUNCTIONS:

The goal of the game is to reach Treasure Island at the top of the screen.

Each turn is split up into two parts: Inspecting and moving

When the words 'Inspect Tile' are displayed in the middle of the arrow controls, press one of the arrows to reveal the tile in that direction.
When 'Move' is displayed in the middle of the arrow controls, press one of the arrows to move the ship in that direction. You don't have to move onto the 
tile that you revealed in the inspecting stage.

There are three possible tiles that can be found. The danger tile, the island tile, or the waves tile.
The danger tile displays a Kraken that can damage your ship, reducing it's health by 1 if you sail over it.
The island tile is a place for your ship to rest, and where you can replenish your food stocks.
The waves tile is simply an empty patch of ocean which won't have any effect on your ship.

Every movement costs 1 food. If either your Health or Food goes down to zero, it's game over.
Also each time you move, previously revealed tiles will become invisible once again. It's important to keep a mental map of where both the dangers and islands are 
if you want to survive the game.


LEVELS:
level 1
An easy starting point, with a small number of danger tiles and 3 health

Level 2 
Increases the challenge with only two health points and a greater number of danger tiles.

Developer Test Level
In order to facilitate testing, in this level the leftmost column is filled with island tiles and the second column is filled with danger tiles.