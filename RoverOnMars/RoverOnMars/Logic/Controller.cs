using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars.Logic
{
    public class Controller
    {
        private Map _map;
        public Controller(Map map)
        {
            _map = map;
        }

        public void Move(int x, int y)
        {
            if (0<=x && x<=15 && 0<=y && y<=15)
            {
                Console.Clear();
                _map.Numbers[_map.Rover.Row, _map.Rover.Column] = 0;
                _map.Rover.Row = x;
                _map.Rover.Column = y;
            }
            else
                Console.WriteLine("Given values are out of map.");
        }
    }
}
