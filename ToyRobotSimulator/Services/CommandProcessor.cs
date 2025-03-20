using System;
using ToyRobotSimulator.Models;

namespace ToyRobotSimulator.Services
{
    public class CommandProcessor
    {
        private readonly Robot _robot;

        public CommandProcessor()
        {
            _robot = new Robot(new Tabletop());
        }

        public void ProcessCommand(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length == 0) return;

            switch (parts[0].ToUpper())
            {
                case "PLACE":
                    if (parts.Length > 1)
                    {
                        var args = parts[1].Split(',');
                        if (args.Length == 3 && int.TryParse(args[0], out int x) && int.TryParse(args[1], out int y))
                        {
                            _robot.Place(x, y, args[2].ToUpper());
                        }
                        else
                        {
                            Console.WriteLine("Invalid PLACE command format. Use: PLACE X,Y,DIRECTION");
                        }
                    }
                    break;
                case "MOVE": _robot.Move(); break;
                case "LEFT": _robot.Left(); break;
                case "RIGHT": _robot.Right(); break;
                case "REPORT": _robot.Report(); break;
                default: Console.WriteLine("Invalid command! Available commands: PLACE X,Y,DIRECTION | MOVE | LEFT | RIGHT | REPORT"); break;
            }
        }
    }
}
