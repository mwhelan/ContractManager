using System;
using AutoPoco.Engine;

namespace ContractManager.Infrastructure.Data.Sources
{
    public class LocationSource : DatasourceBase<string>
    {
        private static readonly Random _random = new Random();
        public override string Next(IGenerationSession session)
        {
            return Data[_random.Next(0, Data.Length)];
        }

        private static readonly string[] Data =
        {
            "London",
            "The City",
            "Canary Wharf",
            "City of London",
            "Central London",
            "Reading",
            "Guildford",
            "Richmond"
        };
    }
}