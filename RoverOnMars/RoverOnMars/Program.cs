using RoverOnMars.Enums;
using RoverOnMars.Logic;
using RoverOnMars.Logic.Commands;
using System;

namespace RoverOnMars
{
    class Program
    {
        private ProgramData _pData = new ProgramData();

        static void Main(string[] args)
        {
            var program = new Program();
            program._pData.Map.DrawMap();
            program.ParseCommands(args);
        }

        public void ParseCommands(string[] arguments)
        {
            int size = arguments.Length;
            string nextArg = "";
            string nextArg2 = "";
            for (var counter = 0; counter < arguments.Length; counter++)
            {
                if (counter + 1 < size)
                    nextArg = arguments[counter + 1];
                switch (arguments[counter])
                {
                    case "--c":
                    case "--command":
                        if (counter + 1 < size)
                            nextArg = arguments[counter + 1];
                        switch (nextArg)
                        {
                            case "move":
                                if (counter + 1 < size)
                                    nextArg = arguments[counter + 1];
                                switch (nextArg)
                                {
                                    case "-position":
                                    case "-p":
                                        if (counter + 2 < size)
                                        {
                                            nextArg = arguments[counter + 1];
                                            nextArg2 = arguments[counter + 1];
                                            int x = Int32.Parse(nextArg);
                                            int y = Int32.Parse(nextArg2);
                                            _pData.MoveCommand.GetMove(x, y);
                                            //_pData.Command = CommandEnum.Move;
                                        }
                                        break;
                                }
                                break;
                                
                           
                        }
                        break;
                }
            }
        }
        //private void Run()
        //{
        //    switch (_pData.Command)
        //    {
        //        case CommandEnum.Move:
        //            MoveCommand moveCommand = new MoveCommand(_pData.Map);
        //            moveCommand.GetMove();
        //            break;

        //    }
        //}


    }
}
