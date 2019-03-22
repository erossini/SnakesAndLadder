using SnakesAndLadder.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Services
{
    public class DiceService : IDiceService
    {
        ILogging _logging;

        public DiceService(ILogging logging)
        {
            _logging = logging;
        }

        public int RollDice()
        {
            _logging.WriteLog("Roll dice");

            Random rnd = new Random();
            return rnd.Next(1, 6);
        }
    }
}