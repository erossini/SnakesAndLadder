using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Services
{
    public class PlayerService : IPlayerService
    {
        ILogging _logging;
        int _numberOfPlayer;

        public PlayerService(int numberOfPlayer, ILogging logging)
        {
            _numberOfPlayer = numberOfPlayer;
            _logging = logging;
        }

        public List<Player> Players { get; set; } = new List<Player>();

        public int TotalPlayers => Players != null ? Players.Count : 0;

        public void AssignPlayers(Player player)
        {
            _logging.WriteLog("Adding a new player");

            if (player != null)
            {
                player.PlayerNumber = TotalPlayers + 1;
                Players.Add(player);

                _logging.WriteLog("New player is added");
            }
        }
    }
}
