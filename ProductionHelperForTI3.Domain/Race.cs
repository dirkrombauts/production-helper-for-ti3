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
}