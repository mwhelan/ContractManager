using System.Collections.Generic;
using System.Linq;
using ContractManager.Domain.Interfaces;
using ContractManager.Domain.Model;
using ContractManager.Domain.Services;
using FizzWare.NBuilder;
using Moq;
using NUnit.Framework;
using Should;
using SpecsFor;

namespace Tests.Unit.ContractManager.Domain.Services
{
    public class when_retrieving_items_from_Rss_feed : SpecsFor<FeedService>
    {
        private IList<JobFeedItem> _result;
        private Job _latestJob;

        protected override void Given()
        {
            _latestJob = Builder<Job>.CreateNew().Build();
            var urls = new List<string>{"www.microsoft.com", "www.google.com", "www.apple.com"};
            GetMockFor<IJobRepository>().Setup(x => x.GetLatestJob()).Returns(_latestJob);

            var feedList = Builder<JobFeed>.CreateListOfSize(3)
                .All().WithConstructor(() => new JobFeed("title", "url"))
                .Build();
            GetMockFor<IJobRepository>().Setup(x => x.GetFeeds()).Returns(feedList);

            IList<JobFeedItem> feedItems = Builder<JobFeedItem>.CreateListOfSize(8).Build();
            GetMockFor<IFeedReader>()
                .Setup(x => x.GetItemsFromFeed(It.IsAny<string>()))
                .ReturnsInOrder(
                    feedItems.Take(3).ToArray(),
                    feedItems.Skip(3).Take(3).ToArray(),
                    feedItems.Skip(5).Take(3).ToArray());
        }

        protected override void When()
        {
            _result = SUT.GetLatestJobs();
        }

        [Test]
        public void Then_it_should_retrieve_the_latest_Job()
        {
            GetMockFor<IJobRepository>().Verify(x => x.GetLatestJob());
        }

        [Test]
        public void Then_it_should_get_values_from_each_feed_since_latest_job()
        {
            GetMockFor<IFeedReader>().Verify(x => x.GetItemsFromFeed(It.IsAny<string>()), Times.Exactly(3));
        }

        [Test]
        public void Then_it_should_merge_the_feeds_into_one_unique_list()
        {
            _result.Count.ShouldEqual(8);
        }
    }
}
