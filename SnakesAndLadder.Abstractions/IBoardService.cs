using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Abstractions
{
    public interface IBoardService
    {
        Cell[] Board { get; set; }

        void AddLadder(int cellNumber, int advantageCell);
        void AddLadder(LadderCell ladderCell);
        void AddSnake(int cellNumber, int penaltyCell);
        void AddSnake(SnakeCell snakeCell);
        void CreateBoard();
    }
}