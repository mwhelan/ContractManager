using ContractManager.Domain.Interfaces.Services;

namespace ContractManager.Application
{
    public class JobFeedService
    {
        private readonly IFeedService _feedService;
        private readonly IJobService _jobService;

        public JobFeedService(IFeedService feedService, IJobService jobService)
        {
            _feedService = feedService;
            _jobService = jobService;
        }

        public void GetLatestJobs()
        {
            var feedItems = _feedService.GetLatestJobs();
            _jobService.CreateJobsFrom(feedItems);
        }
    }
}