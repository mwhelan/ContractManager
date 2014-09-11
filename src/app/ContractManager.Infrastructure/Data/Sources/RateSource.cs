using System;
using AutoPoco.Engine;

namespace ContractManager.Infrastructure.Data.Sources
{
    public class RateSource : DatasourceBase<string>
    {
        private static readonly Random _random = new Random();
        public override string Next(IGenerationSession session)
        {
            return Data[_random.Next(0, Data.Length)];
        }

        private static readonly string[] Data =
        {
            "£450 - £550 per day",
            "£400-450/day",
            "£300 per day",
            "Market rates",
            "325-425 per day",
            "Competitive",
            "Negotiable",
            "£450 per day",
            "up to £500 p/d"
        };
    }
}