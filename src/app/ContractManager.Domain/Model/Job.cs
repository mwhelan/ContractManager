using System;

namespace ContractManager.Domain.Model
{
    public class Job
    {
        public Guid Id { get; private set; }
        public string JobTitle { get; private set; }
        public string Company { get; private set; }
        public string Location { get; private set; }
        public string Skills { get; private set; }
        public DateTime StartDate { get; private set; }
        public string Duration { get; private set; }
        public string Reference { get; private set; }
        //public virtual ICollection<Application> Applications { get; set; }
    }
}
