namespace VacuumRobots.PositionClass
{
    public class SouthPosition : BasePosition, IPosition
    {
        public SouthPosition(IRobot robot) : base(robot) { }
        public string CurrentPosition() { return this.GetCurrentPosition().ToString(); }
        public IRobot Robot { get { return robot; } set { robot = value; } }
        public void Left()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.E);
        }

        public void Move()
        {
            base.robot.Y = robot.Y - 1 >= 0 ? robot.Y - 1 : robot.Y;
        }

        public void Right()
        {
            base.robot.Position = PositionFactory.GeneratePosition(robot, PositionEnum.W);
        }
    }
}
