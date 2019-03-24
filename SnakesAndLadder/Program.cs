using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Services;
using System;

namespace SnakesAndLadder
{
    class Program
    {
        static IBoardService _board;
        static IDiceService _dice;
        static IGameService _game;
        static ILogging _logging;
        static IPlayerService _player;
        static int _boardsize = 100;
        static int _nplayer = 2;

        static void Main(string[] args)
        {
            _logging = new Logging();
            _dice = new DiceService(_logging);

            _board = new BoardService(_boardsize, _logging);
            _board.AddLadder(2, 38);
            _board.AddLadder(7, 14);
            _board.AddLadder(8, 31);
            _board.AddLadder(15, 26);
            _board.AddLadder(28, 84);
            _board.AddLadder(21, 42);
            _board.AddLadder(36, 44);
            _board.AddLadder(51, 67);
            _board.AddLadder(71, 91);
            _board.AddLadder(78, 98);
            _board.AddLadder(87, 94);

            _board.AddSnake(16, 6);
            _board.AddSnake(46, 25);
            _board.AddSnake(49, 11);
            _board.AddSnake(64, 60);
            _board.AddSnake(62, 19);
            _board.AddSnake(74, 53);
            _board.AddSnake(89, 68);
            _board.AddSnake(92, 88);
            _board.AddSnake(95, 75);
            _board.AddSnake(99, 80);

            _player = new PlayerService(_nplayer, _logging);
            _player.AssignPlayers(new Models.Player() { PlayerName = "One" });
            _player.AssignPlayers(new Models.Player() { PlayerName = "Two" });

            if (_player.TotalPlayers > 0)
            {
                _game = new GameService(_board, _dice, _logging, _player);
                _game.Play();
            }

            Console.ReadKey();
        }

        static void AskForBoard()
        {
            Console.WriteLine("Board size?");
            _boardsize = Convert.ToInt32(Console.ReadLine());
        }

        static void AskForLadder()
        {
            bool isLadderCellLeft = true;
            while (isLadderCellLeft)
            {
                Console.WriteLine("Want to define a ladder (|-|-|-|-|-|-|) y/n");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("Ladder cell number");
                    int ladderCellNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Advantage cell number");
                    int advantageCellNumber = Convert.ToInt32(Console.ReadLine());

                    _board.AddLadder(new Models.LadderCell() { AdvantageCell = advantageCellNumber, CellNumber = ladderCellNumber });
                }
                else
                    isLadderCellLeft = false;
            }
        }

        static void AskForPlayer()
        {
            Console.WriteLine("Number of players?");
            _nplayer = Convert.ToInt32(Console.ReadLine());

            _player = new PlayerService(_nplayer, _logging);

            if (_nplayer > 0)
            {
                for (int i = 0; i < _nplayer; i++)
                {
                    Console.WriteLine("Enter your name");
                    string name = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name))
                        _player.AssignPlayers(new Models.Player() { PlayerName = name });
                }
            }
        }

        static void AskForSnake()
        {
            bool isSnakeCellLeft = true;
            while (isSnakeCellLeft)
            {
                Console.WriteLine("Want to define a snake (~~~~~~~~~@) y/n");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("Snake cell number");
                    int snakeCellNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Penalty cell number");
                    int penaltyCellNumber = Convert.ToInt32(Console.ReadLine());

                    _board.AddSnake(new Models.SnakeCell() { CellNumber = snakeCellNumber, PenaltyCell = penaltyCellNumber });
                }
                else
                    isSnakeCellLeft = false;
            }
        }
    }
}
