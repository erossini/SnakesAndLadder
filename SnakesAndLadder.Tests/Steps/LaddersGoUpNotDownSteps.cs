using NUnit.Framework;
using SnakesAndLadder.Models;
using SnakesAndLadder.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    [Binding]
    class LaddersGoUpNotDownSteps : BaseStep
    {
        Player _testPlayer;

        [Given(@"there is a ladder connecting squares (.*) and (.*)")]
        public void GivenThereIsALadderConnectingSquaresAnd(int p0, int p1)
        {
            _board.AddLadder(p0, p1);
            _game = new GameService(_board, _dice, _logging, _player);
            _testPlayer = _player.Players.First();
        }

        [When(@"the token lands on square (.*)")]
        public void WhenTheTokenLandsOnSquare(int p0)
        {
            _testPlayer.CurrentCellPosition = p0 - 1;
            _game.CalculatePlayerPosition(_testPlayer, 1);
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            Assert.AreEqual(p0, _testPlayer.CurrentCellPosition);
        }
    }
}