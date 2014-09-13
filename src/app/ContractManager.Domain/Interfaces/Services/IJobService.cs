using System.Collections.Generic;
using ContractManager.Domain.Model;
using ContractManager.Domain.Services;

namespace ContractManager.Domain.Interfaces.Services
{
    public interface IJobService
    {
        IList<Job> CreateJobsFrom(IList<JobFeedItem> jobFeedItems);
    }
}