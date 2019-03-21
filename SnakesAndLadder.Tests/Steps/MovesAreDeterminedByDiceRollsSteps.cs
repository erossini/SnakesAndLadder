using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class MovesAreDeterminedByDiceRollsSteps
    {
        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the player rolls a die")]
        public void WhenThePlayerRollsADie()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be between (.*) inclusive")]
        public void ThenTheResultShouldBeBetweenInclusive(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the player rolls a (.*)")]
        public void GivenThePlayerRollsA(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"they move their token")]
        public void WhenTheyMoveTheirToken()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the token should move (.*) spaces")]
        public void ThenTheTokenShouldMoveSpaces(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}