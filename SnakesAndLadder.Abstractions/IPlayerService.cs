using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Abstractions
{
    public interface IPlayerService
    {
        List<Player> Players { get; set; }
        int TotalPlayers { get; }

        void AssignPlayers(Player player);
    }
}
