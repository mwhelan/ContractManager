using System;

namespace ContractManager.Domain.Model
{
    public class JobFeed : ValueObject<JobFeed>
    {
        public string Title { get; private set; }
        public string Url { get; private set; }

        public JobFeed(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}