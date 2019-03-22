using SnakesAndLadder.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SnakesAndLadder.Tests.Steps
{
    public class TestLogging : ILogging
    {
        public void WriteError(string message)
        {
            Debug.WriteLine("E " + message);
        }

        public void WriteLog(string message)
        {
            Debug.WriteLine("D " + message);
        }
    }
}
