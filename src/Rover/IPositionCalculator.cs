namespace Rover;

public interface IPositionCalculator
{
    Position GetNextPosition(Position currentPosition, CardinalDirection directionOfMovement);
}