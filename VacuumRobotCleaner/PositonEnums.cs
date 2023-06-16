namespace VacuumRobots
{
    public enum PositionEnum
    {
        N = 1,
        E = 2,
        W = 3,
        S = 4
    }

    public enum MoveEnum
    {
        M = 1,
        L = 2,
        R = 3
    }

    public static class StringExtension
    {
        public static PositionEnum GetPositionEnum(this string position)
        {
            return (PositionEnum)Enum.Parse(typeof(PositionEnum), position);
        }
        public static MoveEnum GetMoveEnum(this char position)
        {
            return (MoveEnum)Enum.Parse(typeof(MoveEnum), position.ToString());
        }
    }
}
