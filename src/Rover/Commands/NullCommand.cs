namespace Rover.Commands;

public class NullCommand : ICommand
{
    public Position Execute(Position position)
    {
        return position;
    }
}