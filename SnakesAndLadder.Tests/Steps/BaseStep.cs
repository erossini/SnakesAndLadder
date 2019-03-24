using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Tests.Steps
{
    public class BaseStep
    {
        public IBoardService _board;
        public IDiceService _dice;
        public IGameService _game;
        public ILogging _logging;
        public IPlayerService _player;

        public int _boardsize = 100;
        public int _nplayer = 2;

        public BaseStep()
        {
            _logging = new TestLogging();
            _dice = new DiceService(_logging);

            _board = new BoardService(_boardsize, _logging);
            //_board.AddLadder(2, 38);
            //_board.AddLadder(7, 14);
            //_board.AddLadder(8, 31);
            //_board.AddLadder(15, 26);
            //_board.AddLadder(28, 84);
            //_board.AddLadder(21, 42);
            //_board.AddLadder(36, 44);
            //_board.AddLadder(51, 67);
            //_board.AddLadder(71, 91);
            //_board.AddLadder(78, 98);
            //_board.AddLadder(87, 94);

            //_board.AddSnake(16, 6);
            //_board.AddSnake(46, 25);
            //_board.AddSnake(49, 11);
            //_board.AddSnake(64, 60);
            //_board.AddSnake(62, 19);
            //_board.AddSnake(74, 53);
            //_board.AddSnake(89, 68);
            //_board.AddSnake(92, 88);
            //_board.AddSnake(95, 75);
            //_board.AddSnake(99, 80);

            _player = new PlayerService(_nplayer, _logging);
            _player.AssignPlayers(new Models.Player() { PlayerName = "Player 1" });
            _player.AssignPlayers(new Models.Player() { PlayerName = "Player 2" });

            _game = new GameService(_board, _dice, _logging, _player);
        }
    }
}
