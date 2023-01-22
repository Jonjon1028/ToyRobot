using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToyRobot.Tests
{
    [TestClass]
    public class ToyRobotTests
    {
        [TestMethod]
        public void Validate_Move_Position()
        {
            ToyRobot robot = new ToyRobot();
            robot.Place(1, 2, Direction.NORTH);
            
            robot.Move();

            Assert.AreEqual(1, robot.row);
            Assert.AreEqual(3, robot.col);
        }

        [TestMethod]
        public void Invalid_Move_Position()
        {
            ToyRobot robot = new ToyRobot();
            robot.Place(4, 2, Direction.NORTH);
            
            for ( int i = 0; i < 5; i++)
            {
                robot.Move();
            }

            Assert.AreEqual(4, robot.row);
            Assert.AreEqual(4, robot.col);
        }
    }
}
