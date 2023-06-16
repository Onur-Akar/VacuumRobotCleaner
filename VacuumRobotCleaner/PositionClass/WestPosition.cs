namespace VacuumRobots.PositionClass
{
    public class WestPosition : BasePosition, IPosition
    {
        public WestPosition(IRobot robot) : base(robot) { }
        public string CurrentPosition() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }
        public void Left()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.S);
        }

        public void Move()
        {
            base.robot.X = robot.X - 1 >= 0 ? robot.X - 1 : robot.X;
        }

        public void Right()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.N);
        }
    }
}
