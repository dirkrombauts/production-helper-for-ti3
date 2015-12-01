using System;
using ProductionHelperForTI3.Domain;

namespace ProductionHelperForTI3.Specification
{
    public class SpaceDock
    {
        private readonly Planet planet;

        private readonly Technology enviroCompensator;

        public SpaceDock(Planet planet, Technology technology)
        {
            this.planet = planet;
            this.enviroCompensator = technology == Technologies.EnviroCompensator ? technology : null;
        }

        public int BuildLimit
        {
            get
            {
                return this.planet.ResourceValue + 2 + (this.enviroCompensator != null ? 1 : 0);
            }
        }
    }
}