using System;
using TechTalk.SpecFlow;

namespace Mars
{
    [Binding]
    public class SkillsStepDefinitions
    {
        [When(@"I added skills and save it")]
        public void WhenIAddedSkillsAndSaveIt()
        {
            throw new PendingStepException();
        }

        [Then(@"the skills should be saved successfully")]
        public void ThenTheSkillsShouldBeSavedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I edited skills and save it")]
        public void WhenIEditedSkillsAndSaveIt()
        {
            throw new PendingStepException();
        }

        [Then(@"the edited skills should be saved successfully")]
        public void ThenTheEditedSkillsShouldBeSavedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then(@"the skills should be removed successfully")]
        public void ThenTheSkillsShouldBeRemovedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
