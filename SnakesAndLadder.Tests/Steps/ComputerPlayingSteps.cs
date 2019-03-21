using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class ComputerPlayingSteps
    {
        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"it is the computer's turn")]
        public void WhenItIsTheComputerSTurn()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the computer should roll and move it's token")]
        public void ThenTheComputerShouldRollAndMoveItSToken()
        {
            ScenarioContext.Current.Pending();
        }
    }
}