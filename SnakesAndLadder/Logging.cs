using SnakesAndLadder.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder
{
    public class Logging : ILogging
    {
        public void WriteError(string message)
        {
            ConsoleColor currentForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = currentForeground;
        }

        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}