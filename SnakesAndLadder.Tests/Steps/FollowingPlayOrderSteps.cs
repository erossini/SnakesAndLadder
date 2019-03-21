using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class FollowingPlayOrderSteps
    {
        [Given(@"it is Player (.*)'s turn")]
        public void GivenItIsPlayerSTurn(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"they have moved their token")]
        public void WhenTheyHaveMovedTheirToken()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"it is Player (.*)'s turn")]
        public void ThenItIsPlayerSTurn(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}