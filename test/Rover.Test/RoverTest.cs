using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Rover.Commands;
using Xunit;

namespace Rover.Test
{
    public class RoverTest
    {
        [Fact]
        public void Move_ExecutesMovementCommand()
        {
            var startPosition = new Position(0, 0, CardinalDirection.North);
            var rover = new Rover(startPosition);
            var newPosition = new Position(10, 10, CardinalDirection.East);

            var command = new Mock<ICommand>();
            command.Setup(x => x.Execute(startPosition)).Returns(newPosition);

            rover.Move(command.Object);

            rover.CurrentPosition.Should().Be(newPosition);
            command.Verify(x => x.Execute(startPosition), Times.Once);
        }
    }
}
