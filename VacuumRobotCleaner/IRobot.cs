using System.Drawing;
using VacuumRobots.PositionClass;

namespace VacuumRobots
{
    public interface IRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IPosition Position { get; set; }
        public Point RoomSize { get; set; }
        public void MoveRobot(string moveList);
    }
}
