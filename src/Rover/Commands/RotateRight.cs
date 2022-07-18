namespace Rover.Commands;

public class RotateRight : ICommand
{
    public Position Execute(Position position)
    {
        return position with { Direction = TurnRight(position.Direction) };
    }

    private CardinalDirection TurnRight(CardinalDirection currentDirection)
    {
        switch (currentDirection)
        {
            case CardinalDirection.North:
                return CardinalDirection.East;
            case CardinalDirection.South:
                return CardinalDirection.West;
            case CardinalDirection.East:
                return CardinalDirection.South;
            case CardinalDirection.West:
                return CardinalDirection.North;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}