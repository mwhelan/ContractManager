using System;

namespace ContractManager.Domain.Model
{
    public class Agency : Entity<Guid>
    {
        public string Name { get; private set; }
        public string Website { get; private set; }
    }
}