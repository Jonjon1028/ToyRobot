namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new ToyRobot();
            robot.Place(1, 2, Direction.SOUTH);
            robot.Move();
            robot.Right();
            robot.Move();
            robot.Report();
        }
    }
}
