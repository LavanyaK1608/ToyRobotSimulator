using Xunit;
using ToyRobotSimulator.Models;

namespace ToyRobotSimulator.Tests
{
    public class RobotTests
    {
        private readonly Tabletop _tabletop;
        private readonly Robot _robot;

        public RobotTests()
        {
            _tabletop = new Tabletop();
            _robot = new Robot(_tabletop);
        }

        [Fact]
        public void Robot_Should_Not_Move_If_Not_Placed()
        {
            _robot.Move();
            Assert.Equal("Robot not placed on the table.", _robot.Report());
        }

        [Fact]
        public void Robot_Should_Place_Correctly()
        {
            _robot.Place(1, 2, "NORTH");
            Assert.Equal("1,2,NORTH", _robot.Report());
        }

        [Fact]
        public void Robot_Should_Not_Fall_Off_Table()
        {
            _robot.Place(4, 4, "NORTH");
            _robot.Move();
            Assert.Equal("4,4,NORTH", _robot.Report());
        }

        [Fact]
        public void Robot_Should_Move_Correctly()
        {
            _robot.Place(2, 2, "EAST");
            _robot.Move();
            Assert.Equal("3,2,EAST", _robot.Report());
        }

        [Fact]
        public void Robot_Should_Rotate_Left()
        {
            _robot.Place(0, 0, "NORTH");
            _robot.Left();
            Assert.Equal("0,0,WEST", _robot.Report());
        }

        [Fact]
        public void Robot_Should_Rotate_Right()
        {
            _robot.Place(0, 0, "NORTH");
            _robot.Right();
            Assert.Equal("0,0,EAST", _robot.Report());
        }
    }
}
