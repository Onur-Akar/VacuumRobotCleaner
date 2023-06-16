namespace VacuumRobots.PositionClass
{
    public interface IPosition
    {
        public void Move();
        public void Left();
        public void Right();
        public string CurrentPosition();
        public IRobot Robot { get; set; }
    }
}
