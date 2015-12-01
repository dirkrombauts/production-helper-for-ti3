using System;

namespace ProductionHelperForTI3.Domain
{
    public class ProductionRun
    {
        private readonly Race race;

        public ProductionRun(Technology technology, Race race)
        {
            this.race = race;

            this.Cost = -(technology == Technologies.SarweenTools ? 1 : 0);
        }

        public int Cost { get; set; }

        public void Produce(int numberOfUnits, Unit unit)
        {
            var cost = (unit.Cost * numberOfUnits);

            if (unit.NumberOfUnitsForCost != 1)
            {
                cost = (cost / unit.NumberOfUnitsForCost) + (cost % unit.NumberOfUnitsForCost);
            }

            if (unit == Units.Dreadnought && this.race == Races.L1z1xMindnet)
            {
                cost = 4 * numberOfUnits;
            }

            this.Cost += cost;
        }
    }
}