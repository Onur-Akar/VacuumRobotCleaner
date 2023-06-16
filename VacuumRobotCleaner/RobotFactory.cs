using System.Drawing;

namespace VacuumRobots
{
    public class RobotFactory
    {
        private int x;
        private int y;
        private Point roomSize;
        private PositionEnum position;
        public RobotFactory() { }

        public IRobot CreateRobot(Point _roomSize, int _x, int _y, PositionEnum _position)
        {
            x = _x;
            y = _y;
            position = _position;
            roomSize = _roomSize;
            IRobot robot = new Robot(x, y, roomSize);
            robot.Position = PositionFactory.GeneratePosition(robot, position);
            return robot;
        }
    }
}
