namespace VacuumRobots.PositionClass
{
    public class NorthPosition : BasePosition, IPosition
    {
        public NorthPosition(IRobot robot) : base(robot) { }
        public string CurrentPosition() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }
        public void Left()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.W);
        }

        public void Move()
        {
            base.robot.Y = robot.RoomSize.Y >= robot.Y + 1 ? robot.Y + 1 : robot.Y;
        }

        public void Right()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.E);
        }
    }
}
