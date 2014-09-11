using System;

namespace ContractManager.Domain.Model
{
    public class Job : Entity<Guid>
    {
        public string JobTitle { get; private set; }
        public string Location { get; private set; }
        public string Duration { get; private set; }
        public string StartDate { get; private set; }
        public string Rate { get; private set; }
        public string Agency { get; private set; }
        public string AgencyLink { get; private set; }
        public string Agent { get; private set; }
        public string AgentEmail { get; private set; }
        public string AgentPhone { get; private set; }
        public string Company { get; private set; }
        public string Skills { get; private set; }
        public string Reference { get; private set; }
        public string Permalink { get; private set; }

    }
}
