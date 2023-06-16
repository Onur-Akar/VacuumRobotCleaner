using VacuumRobots.PositionClass;

namespace VacuumRobots
{
    public static class PositionFactory
    {
        private static Dictionary<string, IPosition> PositionStorage = new Dictionary<string, IPosition>();

        public static IPosition GeneratePosition(IRobot robot, PositionEnum positionType)
        {
            if (PositionStorage.TryGetValue(positionType.ToString(), out var position))
            {
                position.Robot = robot;
                return position;
            }
            else
            {
                var newPosition = CreatePositon(positionType, robot);
                PositionStorage.Add(positionType.ToString(), newPosition);
                return newPosition;
            }
        }
        public static IPosition CreatePositon(PositionEnum position, IRobot robot)
        {
            return position switch
            {
                PositionEnum.W => new WestPosition(robot),
                PositionEnum.N => new NorthPosition(robot),
                PositionEnum.E => new EastPosition(robot),
                PositionEnum.S => new SouthPosition(robot),
                _ => throw new ArgumentException("Invalid enum value for command", position.ToString())
            };
        }
    }
}
