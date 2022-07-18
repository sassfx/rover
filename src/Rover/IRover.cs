using Rover.Commands;

namespace Rover;

public interface IRover
{
    void Move(ICommand command);
}