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
    [Scope(Feature = "TokenCanMoveAcrossTheBoard")]
    class TokenCanMoveAcrossTheBoardSteps : BaseStep
    {
        Player _testPlayer;

        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            _testPlayer = _player.Players.First();
        }

        [When(@"the token is placed on the board")]
        public void WhenTheTokenIsPlacedOnTheBoard()
        {
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            Assert.AreEqual(p0, _testPlayer.CurrentCellPosition);
        }

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

        [When(@"then it is moved (.*) spaces")]
        public void WhenThenItIsMovedSpaces(int p0)
        {
            _game.CalculatePlayerPosition(_testPlayer, p0);
        }
    }
}