using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Abstractions
{
    public interface ILogging
    {
        void WriteLog(string message);
        void WriteError(string message);
    }
}