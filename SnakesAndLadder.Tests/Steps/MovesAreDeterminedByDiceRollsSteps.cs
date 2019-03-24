using NUnit.Framework;
using SnakesAndLadder.Abstractions;
using SnakesAndLadder.Models;
using SnakesAndLadder.Services;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    [Binding]
    public class MovesAreDeterminedByDiceRollsSteps : BaseStep
    {
        int _diceResult;

        Player _testPlayer;
        int _start = 1;
        int _end;
        int _ndice;

        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            _game = new GameService(_board, _dice, _logging, _player);
        }

        [When(@"the player rolls a die")]
        public void WhenThePlayerRollsADie()
        {
            _diceResult = _dice.RollDice();
        }

        [Then(@"the result should be between (.*) and (.*) inclusive")]
        public void ThenTheResultShouldBeBetweenAndInclusive(int p0, int p1)
        {
            bool rtn = true;

            if (_diceResult < p0 || _diceResult > p1)
                rtn = false;

            Assert.IsTrue(rtn);
        }

        [Given(@"the player rolls a (.*)")]
        public void GivenThePlayerRollsA(int p0)
        {
            _ndice = p0;
        }
        
        [When(@"they move their token")]
        public void WhenTheyMoveTheirToken()
        {
            _testPlayer = _player.Players.First();
            _testPlayer.CurrentCellPosition = _start;

            _game.CalculatePlayerPosition(_testPlayer, _ndice);
            _end = _testPlayer.CurrentCellPosition;
        }
        
        [Then(@"the token should move (.*) spaces")]
        public void ThenTheTokenShouldMoveSpaces(int p0)
        {
            Assert.AreEqual(p0, _end - _start);
        }
    }
}