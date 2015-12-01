using System;

namespace ProductionHelperForTI3.Domain
{
    public class Race
    {
        public Race(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }

    public static class Races
    {
        public static Race L1z1xMindnet = new Race("L1z1x Mindnet");
    }
}