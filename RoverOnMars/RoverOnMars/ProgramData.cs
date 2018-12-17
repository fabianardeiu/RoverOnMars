using RoverOnMars.Enums;
using RoverOnMars.Logic;
using RoverOnMars.Logic.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars
{
    public class ProgramData
    {
        //public CommandEnum Command { get; set; }
        public Map Map { get; set; }
        public MoveCommand MoveCommand { get; set; }
    }
}
