namespace Rover.Commands;

public interface ICommand
{
    Position Execute(Position position);
}