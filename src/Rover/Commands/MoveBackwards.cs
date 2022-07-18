namespace Rover.Commands;

public class MoveBackwards : ICommand
{
    public Position Execute(Position position)
    {
        var changeInX = 0;
        var changeInY = 0;

        switch (position.Direction)
        {
            case CardinalDirection.North:
                changeInY = -1;
                break;
            case CardinalDirection.South:
                changeInY = 1;
                break;
            case CardinalDirection.East:
                changeInX = -1;
                break;
            case CardinalDirection.West:
                changeInX = 1;
                break;
        }

        return new Position(position.X + changeInX, position.Y + changeInY, position.Direction);
    }
}