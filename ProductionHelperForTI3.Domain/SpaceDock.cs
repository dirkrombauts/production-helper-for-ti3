using System;

namespace ProductionHelperForTI3.Domain
{
    public class SpaceDock
    {
        private readonly Planet planet;

        private readonly bool hasEnviroCompensator;

        public SpaceDock(Planet planet, Technology technology)
        {
            this.planet = planet;
            this.hasEnviroCompensator = technology == Technologies.EnviroCompensator;
        }

        public int BuildLimit
        {
            get
            {
                return this.planet.ResourceValue + 2 + (this.hasEnviroCompensator ? 1 : 0);
            }
        }
    }
}