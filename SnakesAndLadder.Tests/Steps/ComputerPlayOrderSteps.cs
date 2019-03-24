using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SnakesAndLadder.Tests.Steps
{
    class ComputerPlayOrderSteps
    {
        [Given(@"there is a computer controller character")]
        public void GivenThereIsAComputerControllerCharacter()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the game is started")]
        public void WhenTheGameIsStarted()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the computer should roll for it's turn order")]
        public void ThenTheComputerShouldRollForItSTurnOrder()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"it is that character's turn")]
        public void WhenItIsThatCharacterSTurn()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"they should roll the dice and move their token")]
        public void ThenTheyShouldRollTheDiceAndMoveTheirToken()
        {
            ScenarioContext.Current.Pending();
        }
    }
}