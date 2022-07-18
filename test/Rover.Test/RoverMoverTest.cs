using FluentAssertions;
using Xunit;

namespace Rover.Test
{
    public  class RoverMoverTest
    {
        [Fact]
        public void MoveRover_CorrectlyMovesTheRover()
        {
            var rover = new Rover();
            var commandParser = new CommandParser();
            var roverMover = new RoverMover(rover, commandParser);

            var commands = "FFRFF";
            roverMover.MoveRover(commands);

            rover.CurrentPosition.X.Should().Be(2);
            rover.CurrentPosition.Y.Should().Be(2);
            rover.CurrentPosition.Direction.Should().Be(CardinalDirection.East);
        }
    }
}
