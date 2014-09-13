using System.Collections.Generic;
using ContractManager.Application.ViewModels;

namespace ContractManager.Application.Services
{
    public interface IJobService
    {
        IList<JobListView> GetJobs();
    }
}