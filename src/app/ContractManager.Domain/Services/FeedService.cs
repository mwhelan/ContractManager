using System.Collections.Generic;
using System.Linq;
using ContractManager.Domain.Interfaces;
using ContractManager.Domain.Interfaces.Services;

namespace ContractManager.Domain.Services
{
    public class FeedService : IFeedService
    {
        private readonly IJobRepository _repository;
        private readonly IFeedReader _feedReader;

        public FeedService(IJobRepository repository, IFeedReader feedReader)
        {
            _repository = repository;
            _feedReader = feedReader;
        }

        public IList<JobFeedItem> GetLatestJobs()
        {
            var jobFeedItems = new List<JobFeedItem>();
            var job = _repository.GetLatestJob();
            var feeds = _repository.GetFeeds();
            foreach (var feed in feeds)
            {
                var feedItems = _feedReader.GetItemsFromFeed(feed.Url);
                jobFeedItems = jobFeedItems.Union(feedItems).ToList();
            }

            return jobFeedItems;
        }
    }

    public interface IFeedReader
    {
        IList<JobFeedItem> GetItemsFromFeed(string url);
    }
}