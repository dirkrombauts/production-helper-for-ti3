using System;

namespace ProductionHelperForTI3.Domain
{
    public class ProductionRun
    {
        private readonly Race race;

        private Technology technology;

        public ProductionRun(Technology technology, Race race)
        {
            this.race = race;
            this.technology = technology == Technologies.SarweenTools ? technology : null;

            this.Cost = -(this.technology != null ? 1 : 0);
        }

        public int Cost { get; set; }

        public void Produce(int numberOfUnits, Unit unit)
        {
            var cost = (unit.Cost * numberOfUnits);

            if (unit.NumberOfUnitsForCost != 1)
            {
                cost = (cost / unit.NumberOfUnitsForCost) + (cost % unit.NumberOfUnitsForCost);
            }

            if (unit == Units.Dreadnought && this.race?.Name == "L1z1x Mindnet")
            {
                cost = 4 * numberOfUnits;
            }

            this.Cost += cost;
        }
    }
}