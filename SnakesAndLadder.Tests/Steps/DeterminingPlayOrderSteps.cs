using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class DeterminingPlayOrderSteps
    {
        [Given(@"there are two players")]
        public void GivenThereAreTwoPlayers()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the game is started")]
        public void WhenTheGameIsStarted()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the players must roll dice to determine their play order")]
        public void ThenThePlayersMustRollDiceToDetermineTheirPlayOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the players are rolling to determine play order")]
        public void GivenThePlayersAreRollingToDeterminePlayOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Player (.*) rolls higher than Player (.*)")]
        public void WhenPlayerRollsHigherThanPlayer(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Player (.*) rolls first")]
        public void ThenPlayerRollsFirst(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Player (.*) rolls the same as Player (.*)")]
        public void WhenPlayerRollsTheSameAsPlayer(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the players must roll again")]
        public void ThenThePlayersMustRollAgain()
        {
            ScenarioContext.Current.Pending();
        }
    }
}