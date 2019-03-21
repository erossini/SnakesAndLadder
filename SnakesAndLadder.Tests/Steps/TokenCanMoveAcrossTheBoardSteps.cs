using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class TokenCanMoveAcrossTheBoardSteps
    {
        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the token is placed on the board")]
        public void WhenTheTokenIsPlacedOnTheBoard()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            ScenarioContext.Current.Pending();
        }

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

        [When(@"then it is moved (.*) spaces")]
        public void WhenThenItIsMovedSpaces(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}