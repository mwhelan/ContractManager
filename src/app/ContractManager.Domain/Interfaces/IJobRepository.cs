using System.Collections.Generic;
using ContractManager.Domain.Model;

namespace ContractManager.Domain.Interfaces
{
    public interface IJobRepository
    {
        Job GetLatestJob();
        void Save();
        ICollection<JobFeed> GetFeeds();
    }
}