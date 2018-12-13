using RoverOnMars.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars.Logic
{
    public class Rover
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public OrientationEnum Orientation { get; set; }

        public OrientationEnum GetOrientation()
        {
            Random rndOrient = new Random();
            int orientationNr = rndOrient.Next(1, 5);
            switch (orientationNr)
            {
                case 1:
                    Orientation = OrientationEnum.North;
                    break;
                case 2:
                    Orientation = OrientationEnum.South;
                    break;
                case 3:
                    Orientation = OrientationEnum.West;
                    break;
                case 4:
                    Orientation = OrientationEnum.East;
                    break;
            }
            return Orientation;
        }
    }
}
