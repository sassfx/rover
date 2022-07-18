using FluentAssertions;
using Rover.Commands;
using Xunit;

namespace Rover.Test.Commands;

public class RotateRightTest
{
    [Theory]
    [InlineData(1, 1, CardinalDirection.North, CardinalDirection.East)]
    [InlineData(1, 1, CardinalDirection.South, CardinalDirection.West)]
    [InlineData(1, 1, CardinalDirection.East, CardinalDirection.South)]
    [InlineData(1, 1, CardinalDirection.West, CardinalDirection.North)]
    public void Execute_ReturnsCorrectPosition(int x, int y, CardinalDirection direction, CardinalDirection expectedDirection)
    {
        var position = new Position(x, y, direction);
        var command = new RotateRight();

        var result = command.Execute(position);

        result.X.Should().Be(x);
        result.Y.Should().Be(y);
        result.Direction.Should().Be(expectedDirection);
    }
}