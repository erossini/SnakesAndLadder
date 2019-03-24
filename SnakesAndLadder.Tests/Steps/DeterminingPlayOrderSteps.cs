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
    class DeterminingPlayOrderSteps : BaseStep
    {
        Player _testPlayer1;
        Player _testPlayer2;

        [Given(@"there are two players")]
        public void GivenThereAreTwoPlayers()
        {
        }

        [When(@"the game is started")]
        public void WhenTheGameIsStarted()
        {
            _player.AssignDiceToPlayer(1, 1);
            _player.AssignDiceToPlayer(2, 2);
        }

        [Then(@"the players must roll dice to determine their play order")]
        public void ThenThePlayersMustRollDiceToDetermineTheirPlayOrder()
        {
            _testPlayer1 = _player.Players[0];
            _testPlayer2 = _player.Players[1];

            Assert.AreEqual(_testPlayer1.FirstDice, 1);
            Assert.AreEqual(_testPlayer2.FirstDice, 2);
        }

        [Given(@"the players are rolling to determine play order")]
        public void GivenThePlayersAreRollingToDeterminePlayOrder()
        {
        }

        [When(@"Player (.*) rolls higher than Player (.*)")]
        public void WhenPlayerRollsHigherThanPlayer(int p0, int p1)
        {
            _player.AssignDiceToPlayer(p0, 3);
            _player.AssignDiceToPlayer(p1, 1);
        }

        [Then(@"Player (.*) rolls first")]
        public void ThenPlayerRollsFirst(int p0)
        {
            bool rtn = _player.OrderPlayers();
            Assert.IsTrue(rtn);

            Assert.AreEqual(_player.Players.FirstOrDefault().PlayerName, $"Player {p0}");
        }

        [When(@"Player (.*) rolls the same as Player (.*)")]
        public void WhenPlayerRollsTheSameAsPlayer(int p0, int p1)
        {
            _player.AssignDiceToPlayer(1, 1);
            _player.AssignDiceToPlayer(2, 1);
        }

        [Then(@"the players must roll again")]
        public void ThenThePlayersMustRollAgain()
        {
            Assert.IsFalse(_player.CheckDifferentFirstDiceValue());
        }
    }
}