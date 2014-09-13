using System.Collections.Generic;
using ContractManager.Application.ViewModels;

namespace ContractManager.Application.Services
{
    public class JobService : IJobService
    {
        public IList<JobListView> GetJobs()
        {
            return new List<JobListView>();;
        }
    }
}