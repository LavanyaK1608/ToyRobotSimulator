using System;
using ToyRobotSimulator.Services;

namespace ToyRobotSimulator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Toy Robot Simulator!");
            Console.WriteLine("Commands: PLACE X,Y,DIRECTION | MOVE | LEFT | RIGHT | REPORT | EXIT");
            Console.WriteLine("Example: PLACE 0,0,NORTH");

            CommandProcessor processor = new CommandProcessor();
            while (true)
            {
                Console.Write("Enter command: ");
                string command = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(command))
                {
                    Console.WriteLine("Please enter a valid command.");
                    continue;
                }
                if (command.ToUpper() == "EXIT") break;
                processor.ProcessCommand(command);
            }
        }
    }
}
