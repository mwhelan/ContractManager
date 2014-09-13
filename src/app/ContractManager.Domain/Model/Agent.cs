using System;

namespace ContractManager.Domain.Model
{
    public class Agent : Entity<Guid>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public Guid AgencyId { get; private set; }
        public virtual Agency Agency { get; private set; }

        public void SetAgency(Agency agency)
        {
            Agency = agency;
            AgencyId = agency.Id;
        }
    }
}