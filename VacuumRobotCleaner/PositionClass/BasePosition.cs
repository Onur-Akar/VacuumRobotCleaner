namespace VacuumRobots.PositionClass
{
    public class BasePosition
    {
        public IRobot robot;
        public BasePosition(IRobot _robot) { robot = _robot; }
        public PositionEnum GetCurrentPosition()
        {
            return robot.Position switch
            {
                WestPosition => PositionEnum.W,
                NorthPosition => PositionEnum.N,
                EastPosition => PositionEnum.E,
                SouthPosition => PositionEnum.S,
                _ => throw new ArgumentException("Invalid class value for command", robot.Position.ToString())
            };
        }
    }
}
