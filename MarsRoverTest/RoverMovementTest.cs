using MarsRover;
using System;
using Xunit;

namespace MarsRoverTest
{
    public class RoverMovementTest
    {
        

        [Fact]
        public void SpinLeft()
        {
            //arrange
            var postion = new Postion
            {
                PosX = 0,
                PosY = 0,
                CardZ = "W"
            };
            Rover rover = new(postion);
            //act
            rover.SpinLeft();
            //assert 
            Assert.True(rover.card == "S");
        }

        [Fact]
        public void SpinRight()
        {
            //arrange
            var postion = new Postion
            {
                PosX = 0,
                PosY = 0,
                CardZ = "W"
            };
            Rover rover = new(postion);
            //act
            rover.SpinRight();
            //assert 
            Assert.True(rover.card == "N");
        }

        [Fact]
        public void MoveForward()
        {
            //arrange
            var postion = new Postion
            {
                PosX = 0,
                PosY = 0,
                CardZ = "E"
            };
            Rover rover = new(postion);
            //act
            rover.MoveForward();
            //assert 
            Assert.True(rover.y == 0 && rover.x == 1);
        }

        [Fact]
        public void MoveToLocation()
        {
            // move to new location test: new location: 1 3 E
            //arrange
            var postion = new Postion
            {
                PosX = 1,
                PosY = 2,
                CardZ = "N"
            };
            Rover rover = new(postion);
            string[] commands = { "L", "M", "L", "M", "L", "M", "L", "M", "M" };
            //act
            rover.MoveToLocation(commands);
            //assert 
            Assert.True(rover.x == 1 && rover.y == 3 && rover.card == "N");
        }
    }
}