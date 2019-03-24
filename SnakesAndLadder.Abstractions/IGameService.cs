using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Abstractions
{
    public interface IGameService
    {
        void CalculatePlayerPosition(Player currPlayer, int diceNumber);
        Player NextChance(Player currPlayer);
        void Play();
    }
}
