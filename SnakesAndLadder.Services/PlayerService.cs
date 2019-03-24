using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadder.Services
{
    public class PlayerService : IPlayerService
    {
        ILogging _logging;

        public PlayerService(ILogging logging)
        {
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

        public void AssignDiceToPlayer(int playerNumber, int dice)
        {
            Player player = Players.Where(p => p.PlayerNumber == playerNumber).FirstOrDefault();
            if (player != null)
                player.FirstDice = dice;
        }

        public bool CheckDifferentFirstDiceValue()
        {
            int values = Players.GroupBy(p => p.FirstDice).Select(l => new { l.Key, Num = l.Count() }).Where(a => a.Num > 1).Count();
            return values > 1;
        }

        public bool OrderPlayers()
        {
            bool rtn = false;

            if (!CheckDifferentFirstDiceValue() && Players.Count < 4)
            {
                Players = Players.OrderByDescending(p => p.FirstDice).ToList();

                int index = 0;
                foreach(Player p in Players)
                {
                    p.PlayerNumber = index + 1;
                    index++;
                }

                rtn = true;
            }

            return rtn;
        }
    }
}