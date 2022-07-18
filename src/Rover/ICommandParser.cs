using Rover.Commands;

namespace Rover;

public interface ICommandParser
{
    IEnumerable<ICommand> ParseCommands(string commandString);
}