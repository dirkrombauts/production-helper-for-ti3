using System;

namespace ProductionHelperForTI3.Domain
{
    public class ProductionRun
    {
        private Technology technology;

        public ProductionRun(Technology technology)
        {
            this.technology = technology?.Name == "Sarween Tools" ? technology : null;

            this.Cost = -(this.technology != null ? 1 : 0);
        }

        public int Cost { get; set; }

        public void Produce(int numberOfUnits, Unit unit)
        {
            var cost = (unit.Cost * numberOfUnits);

            if (unit.Name == "Ground Force" || unit.Name == "Fighter")
            {
                cost = (cost / 2) + (cost % 2);
            }

            this.Cost += cost;
        }
    }
}