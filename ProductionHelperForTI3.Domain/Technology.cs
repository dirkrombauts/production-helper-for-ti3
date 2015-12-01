using System;

namespace ProductionHelperForTI3.Domain
{
    public class Technology
    {
        public Technology(string name)
        {
            this.Name = name;
        }

        public string Name { get; }   
    }
}