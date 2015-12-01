using TechTalk.SpecFlow;

namespace ProductionHelperForTI3.Specification.AutomationLayer
{
    [Binding]
    public class Bindings
    {
        [When(@"I produce '(.*)' '(.*)'")]
        public void WhenIProduce(int numberOfUnits, string nameOfUnits)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have the '(.*)' Technology")]
        public void GivenIHaveTheTechnology(string technology)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I have to pay '(.*)' resource")]
        [Then(@"I have to pay '(.*)' resources")]
        [Then(@"I have to pay '(.*)' resource\(s\)")]
        public void ThenIHaveToPayResources(int numberOfResources)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"my Race is the '(.*)'")]
        public void GivenMyRaceIsThe(string nameOfRace)
        {
            ScenarioContext.Current.Pending();
        }
    }
}