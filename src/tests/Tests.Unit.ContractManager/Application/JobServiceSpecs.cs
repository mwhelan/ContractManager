using System.Collections.Generic;
using ContractManager.Application;
using ContractManager.Domain.Interfaces.Services;
using ContractManager.Domain.Services;
using FizzWare.NBuilder;
using NUnit.Framework;
using SpecsFor;

namespace Tests.Unit.ContractManager.Application
{
    public class When_downloading_the_latest_jobs_from_external_feeds : SpecsFor<JobFeedService>
    {
        private IList<JobFeedItem> _jobFeedItems;  
        
        protected override void Given()
        {
            _jobFeedItems = Builder<JobFeedItem>.CreateListOfSize(11).Build();
            GetMockFor<IFeedService>()
                .Setup(x => x.GetLatestJobs())
                .Returns(_jobFeedItems);
            GetMockFor<IJobService>()
                .Setup(x => x.CreateJobsFrom(_jobFeedItems));
        }

        protected override void When()
        {
            SUT.GetLatestJobs();
        }

        [Test]
        public void Then_it_should_get_the_latest_jobs_from_the_job_sites()
        {
            GetMockFor<IFeedService>().Verify(x => x.GetLatestJobs());
        }

        [Test]
        public void Then_it_should_save_the_new_jobs()
        {
            GetMockFor<IJobService>().Verify(x => x.CreateJobsFrom(_jobFeedItems));
        }
    }
}
