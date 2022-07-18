using FluentAssertions;
using Rover.Commands;
using Xunit;

namespace Rover.Test
{
    public class CommandParserTest
    {
        [Theory]
        [InlineData("F", typeof(MoveForwards))]
        [InlineData("B", typeof(MoveBackwards))]
        [InlineData("L", typeof(RotateLeft))]
        [InlineData("R", typeof(RotateRight))]
        public void ParseCommands_ParsesAllCommandTypes(string commandString, Type expectedCommandType)
        {
            var commandParser = new CommandParser();

            var result = commandParser.ParseCommands(commandString);

            result.Should().NotBeNull();
            result.Count().Should().Be(1);

            var command = result.Single();
            command.Should().BeOfType(expectedCommandType);
        }


        [Fact]
        public void ParseCommands_UnsupportedCommandType_ReturnsNullCommand()
        {
            var commandParser = new CommandParser();

            var result = commandParser.ParseCommands(".");

            result.Should().NotBeNull();
            result.Count().Should().Be(1);

            var command = result.Single();
            command.Should().BeOfType<NullCommand>();
        }

        [Fact]
        public void ParseCommands_CorrectlyParsesLongerCommandString()
        {
            const string commandString = "FFRFF";
            var commandParser = new CommandParser();

            var result = commandParser.ParseCommands(commandString);

            result.Should().NotBeNull();
            var resultArray = result.ToArray();
            resultArray.Length.Should().Be(5);
            resultArray[0].Should().BeOfType<MoveForwards>();
            resultArray[1].Should().BeOfType<MoveForwards>();
            resultArray[2].Should().BeOfType<RotateRight>();
            resultArray[3].Should().BeOfType<MoveForwards>();
            resultArray[4].Should().BeOfType<MoveForwards>();
        }
    }
}