namespace Rover;

public class RoverMover : IRoverMover
{
    private readonly IRover _rover;
    private readonly ICommandParser _commandParser;

    public RoverMover(IRover rover, ICommandParser commandParser)
    {
        _rover = rover;
        _commandParser = commandParser;
    }

    public void MoveRover(string commandString)
    {
        var commands = _commandParser.ParseCommands(commandString);
        foreach (var command in commands)
        {
            _rover.Move(command);
        }
    }
}