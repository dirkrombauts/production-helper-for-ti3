using System;
using ProductionHelperForTI3.Domain;
using TechTalk.SpecFlow;

namespace ProductionHelperForTI3.Specification.AutomationLayer
{
    [Binding]
    public class StepArgumentTransformations
    {
        [StepArgumentTransformation]
        public Unit CreateUnit(string nameOfUnits)
        {
            switch (nameOfUnits)
            {
                case "Ground Forces":
                case "Ground Force":
                    {
                        return Units.GroundForce;
                    }

                case "Mechanized Unit":
                case "Mechanized Units":
                    {
                        return Units.MechanizedUnit;
                    }

                case "PDS":
                    {
                        return Units.PDS;
                    }

                case "Space Dock":
                case "Space Docks":
                    {
                        return Units.SpaceDock;
                    }

                case "Fighters":
                case "Fighter":
                    {
                        return Units.Fighter;
                    }

                case "Destroyer":
                case "Destroyers":
                    {
                        return Units.Destroyer;
                    }

                case "Cruiser":
                    {
                        return Units.Cruiser;
                    }

                case "Carrier":
                case "Carriers":
                    {
                        return Units.Carrier;
                    }

                case "Dreadnought":
                case "Dreadnoughts":
                    {
                        return Units.Dreadnought;
                    }

                case "War Sun":
                case "War Suns":
                    {
                        return Units.WarSun;
                    }

                default:
                    {
                        return null;
                    }
            }
        }
    }
}