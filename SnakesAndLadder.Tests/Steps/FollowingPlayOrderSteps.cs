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
    class FollowingPlayOrderSteps : BaseStep
    {
        Player _testPlayer;

        [Given(@"it is Player (.*)'s turn")]
        public void GivenItIsPlayerSTurn(int p0)
        {
            _player.AssignDiceToPlayer(1, 2);
            _player.AssignDiceToPlayer(2, 1);
            _player.OrderPlayers();

            _testPlayer = _player.Players[p0 - 1];
            Assert.AreEqual(_testPlayer.PlayerNumber, p0);
        }

        [When(@"they have moved their token")]
        public void WhenTheyHaveMovedTheirToken()
        {
            _game.CalculatePlayerPosition(_testPlayer, 1);
        }

        [Then(@"it is Player (.*)'s turn")]
        public void ThenItIsPlayerSTurn(int p0)
        {
            _testPlayer = _game.NextChance(_testPlayer);
            Assert.AreEqual(_testPlayer.PlayerNumber, p0);
        }
    }
}