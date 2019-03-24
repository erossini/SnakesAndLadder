using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Services
{
    public class BoardService : IBoardService
    {
        ILogging _logging;
        int _boardSize;

        public BoardService(int boardSize, ILogging logging)
        {
            _boardSize = boardSize;
            _logging = logging;

            CreateBoard();
        }

        public Cell[] Board { get; set; }

        public void CreateBoard()
        {
            _logging.WriteLog("Create a new board");

            Board = new Cell[_boardSize];
            for (int i = 0; i < _boardSize; i++)
            {
                Cell c = new Cell();
                c.CellNumber = i + 1;
                Board[i] = c;
            }
        }

        public void AddLadder(int cellNumber, int advantageCell)
        {
            AddLadder(new LadderCell() { AdvantageCell = advantageCell, CellNumber = cellNumber });
        }

        public void AddLadder(LadderCell ladderCell)
        {
            if (ladderCell != null)
                if (ladderCell.CellNumber < ladderCell.AdvantageCell)
                    Board[ladderCell.CellNumber - 1] = ladderCell;
                else
                    throw new Exception("The ladder must start in a cell in a lower position of the advantage cell");

            _logging.WriteLog("Added a new ladder");
        }

        public void AddSnake(int cellNumber, int penaltyCell)
        {
            AddSnake(new SnakeCell() { CellNumber = cellNumber, PenaltyCell = penaltyCell });
        }

        public void AddSnake(SnakeCell snakeCell)
        {
            if (snakeCell != null)
                if (snakeCell.CellNumber > snakeCell.PenaltyCell)
                    Board[snakeCell.CellNumber - 1] = snakeCell;
                else
                    throw new Exception("The snake must start in a cell in a higer position of the penality cell");

            _logging.WriteLog("Added a new snake");
        }
    }
}
