using System.Drawing;
using VacuumRobots.PositionClass;

namespace VacuumRobots
{
    internal class Robot : IRobot
    {
        private int x;
        private int y;
        private Point roomSize;
        private IPosition position;

        public Robot(int _x, int _y, Point _roomSize)
        {
            X = _x;
            Y = _y;
            roomSize = _roomSize;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public IPosition Position { get => position; set => position = value; }
        public Point RoomSize { get => roomSize; set => roomSize = value; }
        public void MoveRobot(string moveList)
        {
            moveList.ToList().ForEach(p =>
            {
                switch (p.GetMoveEnum())
                {
                    case MoveEnum.M:
                        Position.Move();
                        break;
                    case MoveEnum.R:
                        Position.Right();
                        break;
                    case MoveEnum.L:
                        Position.Left();
                        break;
                    default:
                        throw new ArgumentException("Invalid enum value for command", p.ToString());
                };
            });
        }
    }
}
