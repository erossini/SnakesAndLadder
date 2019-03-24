using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakesAndLadder.Services
{
    public class GameService : IGameService
    {
        IBoardService _board;
        IDiceService _dice;
        ILogging _logging;
        IPlayerService _players;

        Player currentPlayer;

        public GameService(IBoardService board, IDiceService dice, ILogging logging, IPlayerService players)
        {
            _board = board;
            _dice = dice;
            _logging = logging;
            _players = players;

            _logging.WriteLog("Set new game");
        }

        public void CalculatePlayerPosition(Player currPlayer, int diceNumber)
        {
            _logging.WriteLog($"{currPlayer.PlayerName}: your dice shows {diceNumber}");

            int moveLocation = currPlayer.CurrentCellPosition;
            if ((moveLocation + diceNumber) <= _board.Board.Length)
            {
                moveLocation = moveLocation + diceNumber;
                _logging.WriteLog($"{currPlayer.PlayerName}: moved to {moveLocation}");
            }
            else
            {
                _logging.WriteLog($"{currPlayer.PlayerName}: stays at {moveLocation}");
            }

            while (_board.Board[moveLocation - 1].GetType() == typeof(SnakeCell) || _board.Board[moveLocation - 1].GetType() == typeof(LadderCell))
            {
                if (_board.Board[moveLocation - 1].GetType() == typeof(SnakeCell))
                {
                    moveLocation = (_board.Board[moveLocation - 1] as SnakeCell).PenaltyCell;
                    _logging.WriteLog($"{currPlayer.PlayerName}: snake bite moving to {moveLocation}");
                }
                if (_board.Board[moveLocation - 1].GetType() == typeof(LadderCell))
                {
                    moveLocation = (_board.Board[moveLocation - 1] as LadderCell).AdvantageCell;
                    _logging.WriteLog($"{currPlayer.PlayerName}: found ladder moving to {moveLocation}");
                }
            }
            currPlayer.CurrentCellPosition = moveLocation;

            if (currPlayer.CurrentCellPosition == _board.Board.Length)
                currPlayer.IsTheWinner = true;
        }

        public Player NextChance(Player currPlayer)
        {
            Player rtn;
            _logging.WriteLog("NextChange");

            if (currPlayer.PlayerNumber < _players.TotalPlayers)
                rtn = _players.Players.Skip(currPlayer.PlayerNumber).First();
            else
                rtn = _players.Players.First();

            return rtn;
        }

        public void Play()
        {
            _logging.WriteLog("Start the Game");

            bool isFirstMove = true;
            currentPlayer = _players.Players.First();

            while (currentPlayer.CurrentCellPosition != _board.Board.Length)
            {
                if (!isFirstMove)
                    currentPlayer = NextChance(currentPlayer);

                isFirstMove = false;
                CalculatePlayerPosition(currentPlayer, _dice.RollDice());
            }

            _logging.WriteLog($"{currentPlayer.PlayerName} WINS!");

            foreach (Player p in _players.Players)
                _logging.WriteLog($"{p.PlayerName} is at {p.CurrentCellPosition}");

            _logging.WriteLog("Game Over!!!");
        }
    }
}