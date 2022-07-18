using FluentAssertions;
using Rover.Commands;
using Xunit;

namespace Rover.Test.Commands;

public class MoveForwardsTest
{
    [Theory]
    [InlineData(1, 1, CardinalDirection.North, 1, 2)]
    [InlineData(1, 1, CardinalDirection.South, 1, 0)]
    [InlineData(1, 1, CardinalDirection.East, 2, 1)]
    [InlineData(1, 1, CardinalDirection.West, 0, 1)]
    public void Execute_ReturnsCorrectPosition(int startX, int startY, CardinalDirection direction, int expectedX, int expectedY)
    {
        var position = new Position(startX, startY, direction);
        var command = new MoveForwards();

        var result = command.Execute(position);

        result.X.Should().Be(expectedX);
        result.Y.Should().Be(expectedY);
        result.Direction.Should().Be(direction);
    }
}