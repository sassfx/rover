using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rover.Commands;

namespace Rover
{
    public class Rover : IRover
    {
        public Position CurrentPosition { get; private set; }

        public Rover()
        {
            CurrentPosition = new Position(0, 0, CardinalDirection.North);
        }

        public Rover(Position position)
        {
            CurrentPosition = position;
        }

        public void Move(ICommand command)
        {
            var newPosition = command.Execute(CurrentPosition);
            CurrentPosition = newPosition;
        }
    }
}
