using TechTalk.SpecFlow;
using ProductionHelperForTI3.Domain;

namespace ProductionHelperForTI3.Specification.AutomationLayer
{
    using NFluent;

    [Binding]
    public class Bindings
    {
        private Planet planet;

        private SpaceDock spaceDock;

        private Technology technology;

        private ProductionRun productionRun;

        private Race race;

        [When(@"I produce '(.*)' '(.*)'")]
        public void WhenIProduce(int numberOfUnits, string nameOfUnits)
        {
            var unit = CreateUnit(nameOfUnits);

            if (this.productionRun == null)
            {
                this.productionRun = new ProductionRun(this.technology, this.race);
            }

            this.productionRun.Produce(numberOfUnits, unit);
        }

        private static Unit CreateUnit(string nameOfUnits)
        {
            switch (nameOfUnits)
            {
                case "Dreadnought":
                case "Dreadnoughts":
                    {
                        return Units.Dreadnought;
                    }
            }

            return new Unit(nameOfUnits);
        }

        [Given(@"I have the '(.*)' Technology")]
        public void GivenIHaveTheTechnology(string technology)
        {
            this.technology = new Technology(technology);
        }

        [Then(@"I have to pay '(.*)' resource")]
        [Then(@"I have to pay '(.*)' resources")]
        [Then(@"I have to pay '(.*)' resource\(s\)")]
        public void ThenIHaveToPayResources(int numberOfResources)
        {
            Check.That(this.productionRun.Cost).IsEqualTo(numberOfResources);
        }

        [Given(@"my Race is the '(.*)'")]
        public void GivenMyRaceIsThe(string nameOfRace)
        {
            this.race = new Race(nameOfRace);
        }

        [Given(@"I have a planet with Resource Value '(.*)'")]
        public void GivenIHaveAPlanetWithResourceValue(int resourceValue)
        {
            this.planet = new Planet { ResourceValue = resourceValue };
        }

        [When(@"I produce units at the space dock of that planet")]
        public void WhenIProduceUnitsAtTheSpaceDockOfThatPlanet()
        {
            this.spaceDock = new SpaceDock(this.planet, this.technology);
        }

        [Then(@"the build limit is '(.*)'")]
        public void ThenTheBuildLimitIs(int expectedBuildLimit)
        {
            Check.That(this.spaceDock.BuildLimit).IsEqualTo(expectedBuildLimit);
        }
    }
}