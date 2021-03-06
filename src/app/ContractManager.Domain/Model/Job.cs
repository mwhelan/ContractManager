﻿using System;

namespace ContractManager.Domain.Model
{
    public class Job : Entity<Guid>
    {
        public string JobTitle { get; private set; }
        public string Location { get; private set; }
        public string Duration { get; private set; }
        public DateTime PostedDate { get; private set; }
        public string StartDate { get; private set; }
        public string Rate { get; private set; }
        public string Company { get; private set; }
        public string Skills { get; private set; }
        public string Reference { get; private set; }
        public string Permalink { get; private set; }

        public Guid AgentId { get; private set; }
        public virtual Agent Agent { get; private set; }

        public void SetAgent(Agent agent)
        {
            Agent = agent;
            AgentId = agent.Id;
        }
    }
}
