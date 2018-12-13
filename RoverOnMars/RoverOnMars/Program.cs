using RoverOnMars.Logic;
using System;

namespace RoverOnMars
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover rover = new Rover();
            Map map = new Map(rover);
            Controller controller = new Controller(map);
            map.DrawMap();
            controller.Move(1, 1);
            map.ResetMap();


            Console.ReadLine();
        }
    }
}
