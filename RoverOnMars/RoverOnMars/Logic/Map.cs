using RoverOnMars.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOnMars.Logic
{
    public class Map
    {
        public Map(Rover rover)
        {
            Rover = rover;
            Numbers = new int[15, 15];
        }
        public Rover Rover { get; set; }
        public int[,] Numbers { get; set; }

        public void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rover on Mars\n\n\n");
            Console.ResetColor();
            Random rnd = new Random();
            Rover.Row = rnd.Next(0, 15);
            Rover.Column = rnd.Next(0, 15);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (i == Rover.Row && j == Rover.Column)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        switch (Rover.GetOrientation())
                        {
                            case OrientationEnum.North:
                                Console.Write("\u2191 ");
                                break;
                            case OrientationEnum.South:
                                Console.Write("\u2193 ");
                                break;
                            case OrientationEnum.West:
                                Console.Write("\u2190 ");
                                break;
                            case OrientationEnum.East:
                                Console.Write("\u2193 ");
                                break;
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(Numbers[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void ResetMap()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rover on Mars\n\n\n");
            Console.ResetColor();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (i == Rover.Row && j == Rover.Column)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        switch (Rover.Orientation)
                        {
                            case OrientationEnum.North:
                                Console.Write("\u2191 ");
                                break;
                            case OrientationEnum.South:
                                Console.Write("\u2193 ");
                                break;
                            case OrientationEnum.West:
                                Console.Write("\u2190 ");
                                break;
                            case OrientationEnum.East:
                                Console.Write("\u2192 ");
                                break;
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(Numbers[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
