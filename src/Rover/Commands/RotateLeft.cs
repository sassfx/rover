namespace Rover.Commands;

public class RotateLeft : ICommand
{
    public Position Execute(Position position)
    {
        return position with { Direction = TurnLeft(position.Direction) };
    }

    private CardinalDirection TurnLeft(CardinalDirection currentDirection)
    {
        switch (currentDirection)
        {
            case CardinalDirection.North:
                return CardinalDirection.West;
            case CardinalDirection.South:
                return CardinalDirection.East;
            case CardinalDirection.East:
                return CardinalDirection.North;
            case CardinalDirection.West:
                return CardinalDirection.South;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}