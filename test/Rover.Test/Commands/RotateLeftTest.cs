using FluentAssertions;
using Rover.Commands;
using Xunit;

namespace Rover.Test.Commands;

public class RotateLeftTest
{
    [Theory]
    [InlineData(1, 1, CardinalDirection.North, CardinalDirection.West)]
    [InlineData(1, 1, CardinalDirection.South, CardinalDirection.East)]
    [InlineData(1, 1, CardinalDirection.East, CardinalDirection.North)]
    [InlineData(1, 1, CardinalDirection.West, CardinalDirection.South)]
    public void Execute_ReturnsCorrectPosition(int x, int y, CardinalDirection direction, CardinalDirection expectedDirection)
    {
        var position = new Position(x, y, direction);
        var command = new RotateLeft();

        var result = command.Execute(position);

        result.X.Should().Be(x);
        result.Y.Should().Be(y);
        result.Direction.Should().Be(expectedDirection);
    }
}