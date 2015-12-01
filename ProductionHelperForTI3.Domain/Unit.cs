using System;

namespace ProductionHelperForTI3.Domain
{
    public class Unit
    {
        public Unit(string name)
        {
            this.NumberOfUnitsForCost = 1;

            switch (name)
            {
                case "Ground Forces":
                case "Ground Force":
                    {
                        this.Name = "Ground Force";
                        this.Cost = 1;
                        this.NumberOfUnitsForCost = 2;
                        break;
                    }

                case "Mechanized Unit":
                case "Mechanized Units":
                    {
                        this.Name = "Mechanized Unit";
                        this.Cost = 2;
                        break;
                    }

                case "PDS":
                    {
                        this.Name = "PDS";
                        this.Cost = 2;
                        break;
                    }

                case "Space Dock":
                case "Space Docks":
                    {
                        this.Name = "Space Dock";
                        this.Cost = 4;
                        break;
                    }

                case "Fighters":
                case "Fighter":
                    {
                        this.Name = "Fighter";
                        this.Cost = 1;
                        this.NumberOfUnitsForCost = 2;
                        break;
                    }

                case "Destroyer":
                case "Destroyers":
                    {
                        this.Name = "Destroyer";
                        this.Cost = 1;
                        break;
                    }

                case "Cruiser":
                    {
                        this.Name = "Cruiser";
                        this.Cost = 2;
                        break;
                    }

                case "Carrier":
                case "Carriers":
                    {
                        this.Name = "Carrier";
                        this.Cost = 3;
                        break;
                    }

                case "Dreadnought":
                case "Dreadnoughts":
                    {
                        this.Name = "Dreadnought";
                        this.Cost = 5;
                        break;
                    }

                case "War Sun":
                case "War Suns":
                    {
                        this.Name = "War Sun";
                        this.Cost = 12;
                        break;
                    }
            }
        }

        public int Cost { get; }

        public string Name { get; }

        public int NumberOfUnitsForCost { get; }
    }
}