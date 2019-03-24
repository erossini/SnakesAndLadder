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

        void AssignDiceToPlayer(int playerNumber, int dice);
        void AssignPlayers(Player player);
        bool CheckDifferentFirstDiceValue();
        bool OrderPlayers();
    }
}
