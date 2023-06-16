// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using VacuumRobots;

Console.WriteLine("Please enter roomsize with using comma seperator. Etc.: 5,5");
string roomSizeInput = Console.ReadLine();
string[] roomSizeArr = roomSizeInput.Split(',');

Console.WriteLine("Please enter first robot's current x and y position and orientation with using comma seperator. Etc.: 1,2,N");
string robot1CurrentPositionsInput = Console.ReadLine();
string[] robot1CurrentPosArr = robot1CurrentPositionsInput.Split(',');

Console.WriteLine("Please enter first robot's movement list without any seperator or space. Etc.: LMLMLMLMM");
string moveList = Console.ReadLine();

Console.WriteLine("Please enter second robot's current x and y position and orientation with using comma seperator. Etc.: 3,3,E");
string robot2CurrentPositionsInput = Console.ReadLine();
string[] robot2CurrentPosArr = robot2CurrentPositionsInput.Split(',');

Console.WriteLine("Please enter second robot's movement list without any seperator or space. Etc.: MMRMMRMRRM");
string moveList2 = Console.ReadLine();

RobotFactory robotFactory = new();

(int width, int height) roomSize = (Convert.ToInt32(roomSizeArr[0]), Convert.ToInt32(roomSizeArr[1]));
(int x, int y, string Position) robotProperties = (Convert.ToInt32(robot1CurrentPosArr[0]), Convert.ToInt32(robot1CurrentPosArr[1]), robot1CurrentPosArr[2].ToUpper());
IRobot robot1 = robotFactory.CreateRobot(new(roomSize.width, roomSize.height), robotProperties.x, robotProperties.y, robotProperties.Position.GetPositionEnum());

robot1.MoveRobot(moveList.ToUpper());
Console.WriteLine($"{robot1.X},{robot1.Y},{robot1.Position.CurrentPosition()}");

(int width, int height) roomSize2 = (Convert.ToInt32(roomSizeArr[0]), Convert.ToInt32(roomSizeArr[1]));
(int x, int y, string Positon) robotProperties2 = (Convert.ToInt32(robot2CurrentPosArr[1]), Convert.ToInt32(robot2CurrentPosArr[1]), robot2CurrentPosArr[2].ToUpper());
IRobot robot2 = robotFactory.CreateRobot(new(roomSize2.width, roomSize2.height), robotProperties2.x, robotProperties2.y, robotProperties2.Positon.GetPositionEnum());

robot2.MoveRobot(moveList2.ToUpper());
Console.WriteLine($"{robot2.X},{robot2.Y},{robot2.Position.CurrentPosition()}");
Console.ReadLine();