
## Rover

Solution to demonstrate a test driven implementation of a simple rover movement.

A command based architecture was chosen as it:
 - Naturally fit the brief	
 - Allows for easy extension in future.

Currently the rover supports moving forwards and backwards as well as turning left or right. If the parser detects an unknown command it will do nothing instead of erroring - this seemed a safer option given that this code will be being sent instructions from space.