using NUnit.Framework;
using SnakesAndLadder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    [Binding]
    [Scope(Feature = "PlayerCanWinTheGame")]
    class PlayerCanWinTheGameSteps : BaseStep
    {
        Player _testPlayer;

        [Given(@"the token is on square (.*)")]
        public void GivenTheTokenIsOnSquare(int p0)
        {
            _testPlayer = _player.Players.First();
            _testPlayer.CurrentCellPosition = p0;
        }

        [When(@"the token is moved (.*) spaces")]
        public void WhenTheTokenIsMovedSpaces(int p0)
        {
            _game.CalculatePlayerPosition(_testPlayer, p0);
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            Assert.AreEqual(p0, _testPlayer.CurrentCellPosition);
        }

        [Then(@"the player has won the game")]
        public void ThenThePlayerHasWonTheGame()
        {
            Assert.IsTrue(_testPlayer.IsTheWinner);
        }

        [Then(@"the player has not won the game")]
        public void ThenThePlayerHasNotWonTheGame()
        {
            Assert.IsFalse(_testPlayer.IsTheWinner);
        }
    }
}