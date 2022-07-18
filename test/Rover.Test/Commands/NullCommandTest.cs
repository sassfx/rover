using FluentAssertions;
using Rover.Commands;
using Xunit;

namespace Rover.Test.Commands;

public class NullCommandTest
{
    [Fact]
    public void Execute_ReturnsCorrectPosition()
    {
        int x = 1;
        int y = 1;
        var direction = CardinalDirection.East;
        var position = new Position(x, y, direction);
        var command = new NullCommand();

        var result = command.Execute(position);

        result.X.Should().Be(x);
        result.Y.Should().Be(y);
        result.Direction.Should().Be(direction);
    }
}