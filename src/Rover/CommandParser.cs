using Rover.Commands;

namespace Rover;

public class CommandParser : ICommandParser
{
    public IEnumerable<ICommand> ParseCommands(string commandString)
    {
        return commandString.ToUpper().Select(ParseCommand);
    }

    private ICommand ParseCommand(char commandCharacter)
    {
        switch (commandCharacter)
        {
            case 'F':
                return new MoveForwards();
            case 'B':
                return new MoveBackwards();
            case 'L':
                return new RotateLeft();
            case 'R':
                return new RotateRight();
            default:
                return new NullCommand();
        }
    }
}