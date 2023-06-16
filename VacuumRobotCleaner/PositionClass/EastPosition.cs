namespace VacuumRobots.PositionClass
{
    public class EastPosition : BasePosition, IPosition
    {
        public EastPosition(IRobot robot) : base(robot) { }
        public string CurrentPosition() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }

        public void Left()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.N);
        }

        public void Move()
        {
            base.robot.X = robot.RoomSize.X >= robot.X + 1 ? robot.X + 1 : robot.X;
        }

        public void Right()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.S);
        }
    }
}
