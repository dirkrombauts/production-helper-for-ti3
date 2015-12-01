using System;

namespace ProductionHelperForTI3.Domain
{
    public static class Units
    {
        public static Unit GroundForce = new Unit("Ground Force", 1, 2);

        public static Unit MechanizedUnit = new Unit("Mechanized Unit", 2);

        public static Unit PDS = new Unit("PDS", 2);

        public static Unit SpaceDock = new Unit("Space Dock", 4);

        public static Unit Fighter = new Unit("Fighter", 1, 2);

        public static Unit Destroyer = new Unit("Destroyer", 1);

        public static Unit Cruiser = new Unit("Cruiser", 2);

        public static Unit Carrier = new Unit("Carrier", 3);

        public static Unit Dreadnought = new Unit("Dreadnought", 5);

        public static Unit WarSun = new Unit("War Sun", 12);
    }
}