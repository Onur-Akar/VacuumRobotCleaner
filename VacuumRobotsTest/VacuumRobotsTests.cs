using VacuumRobots;

namespace VacuumRobotsTest
{
    public class VacuumRobotsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRobot1()
        {
            RobotFactory robotFactory = new();

            (int width, int height) roomSize = (5, 5);
            (int x, int y, string Position) robotProperties = (1, 2, "N");
            IRobot robot1 = robotFactory.CreateRobot(new(roomSize.width, roomSize.height), robotProperties.x, robotProperties.y, robotProperties.Position.GetPositionEnum());

            string moveList = "LMLMLMLMM";
            robot1.MoveRobot(moveList);
            string actualOutputRobot1 = $"{robot1.X} {robot1.Y} {robot1.Position.CurrentPosition()}";

            Assert.That(actualOutputRobot1, Is.EqualTo("1 3 N"));
        }

        [Test]
        public void TestRobot2()
        {
            RobotFactory robotFactory = new();
            (int width, int height) roomSize2 = (5, 5);
            (int x, int y, string Position) robotProperties2 = (3, 3, "E");
            IRobot robot2 = robotFactory.CreateRobot(new(roomSize2.width, roomSize2.height), robotProperties2.x, robotProperties2.y, robotProperties2.Position.GetPositionEnum());

            string moveList2 = "MMRMMRMRRM";
            robot2.MoveRobot(moveList2);
            string acutalOutputRobot2 = $"{robot2.X} {robot2.Y} {robot2.Position.CurrentPosition()}";

            Assert.That(acutalOutputRobot2, Is.EqualTo("5 1 E"));
        }
    }
}