using System;
using System.Collections.Generic;
using System.Linq;
namespace MiningSystem
{
    public class StartUp
    {
        private static bool isRunning = true;
        private static void Main()
        {
            SystemManager systemManager = new SystemManager();
            while (isRunning)
            {
                string input = Console.ReadLine();
                List<string> parsedInput = ParseInput(input);
                string commandResult = DispatchCommand(parsedInput, systemManager);
                Console.WriteLine(commandResult);
            }
        }
        private static string DispatchCommand(List<string> arguments, SystemManager manager)
        {
            string command = arguments[0];
            arguments.RemoveAt(0);
            string result = null;
            switch (command)
            {
                case "RegisterMiner":
                    result = manager.RegisterMiner(arguments);
                    break;
                case "RegisterProvider":
                    result = manager.RegisterProvider(arguments);
                    break;
                case "Day":
                    result = manager.Day();
                    break;
                case "Check":
                    result = manager.Check(arguments);
                    break;
                case "Shutdown":
                    result = manager.ShutDown();
                    isRunning = false;
                    break;
            }
            return result;
        }
        private static List<string> ParseInput(string input)
        {
            return input.Split().ToList();
        }
    }
}
