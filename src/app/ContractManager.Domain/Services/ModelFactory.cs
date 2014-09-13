using ContractManager.Domain.Model;

namespace ContractManager.Domain.Services
{
    public static class ModelFactory
    {
        public static Job Map(this JobFeedItem feedItem)
        {
            return new Job();
        }
    }
}
