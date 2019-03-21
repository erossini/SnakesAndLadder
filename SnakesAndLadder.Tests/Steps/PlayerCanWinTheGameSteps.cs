using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class PlayerCanWinTheGameSteps
    {
        [Given(@"the token is on square (.*)")]
        public void GivenTheTokenIsOnSquare(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the token is moved (.*) spaces")]
        public void WhenTheTokenIsMovedSpaces(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the player has won the game")]
        public void ThenThePlayerHasWonTheGame()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the player has not won the game")]
        public void ThenThePlayerHasNotWonTheGame()
        {
            ScenarioContext.Current.Pending();
        }
    }
}