using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class LaddersGoUpNotDownSteps
    {
        [Given(@"there is a ladder connecting squares (.*) and (.*)")]
        public void GivenThereIsALadderConnectingSquaresAnd(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the token lands on square (.*)")]
        public void WhenTheTokenLandsOnSquare(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}