using System;

namespace ProductionHelperForTI3.Domain
{
    public class Unit
    {
        public Unit(string name, int cost)
            : this(name, cost, 1)
        {
        }

        public Unit(string name, int cost, int numberOfUnits)
        {
            this.Name = name;
            this.Cost = cost;
            this.NumberOfUnitsForCost = numberOfUnits;
        }

        public int Cost { get; }

        public string Name { get; }

        public int NumberOfUnitsForCost { get; }
    }
}