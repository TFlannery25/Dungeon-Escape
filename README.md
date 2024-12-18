# Dungeon-Escape
2D Platformer

Dungeon Escape is a personal project I developed in 2021. The gameplay involves a player-controlled character moving through a 2D world. The game has 9 main levels, with each level featuring various platforms, obstacles, and traps that the player must navigate to complete the game.

# The Player
> The player controls the wizard character in the game using the A and D keys to move left and right, and the spacebar to jump. When the player jumps, they can control the character's movement in the horizontal direction as well. If the player comes into contact with various traps, they will die.

# Traps 
> 1. Spikes
> Spikes are placed at the bottom of pits, on moving walls, and on platforms, and will kill the player on contact.

> 2. Spinnning Sword
> Swords will be mounted on walls and will rotate either clockwise or counterclockwise, killing the player on contact.

> 3. Fire Ball
> Fireballs will move back and forth on either a horizontal or vertical plane and will kill the player on contact.

> 4. Homing Axe
> Featured in level 7, the homing axe slowly moves toward the player while spinning and will kill the player on contact.

# Level Failure and Completion
> To complete the level, the player must find the exit door, which, upon contact, will set the GameManager to take them to the transition room that leads to the next level. If the player dies from any trap throughout the level, they will restart that level.

