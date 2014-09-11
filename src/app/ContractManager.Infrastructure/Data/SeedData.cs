using System.Linq;
using AutoPoco;
using AutoPoco.DataSources;
using AutoPoco.Engine;
using ContractManager.Domain.Model;
using ContractManager.Infrastructure.Data.Sources;

namespace ContractManager.Infrastructure.Data
{
    public class SeedData
    {
        public static void Create(DatabaseContext context)
        {
            var factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => { c.UseDefaultConventions(); });
                x.AddFromAssemblyContainingType<Job>();

                x.Include<Job>()
                    .Setup(job => job.Location).Use<LocationSource>()
                    .Setup(job => job.Rate).Use<RateSource>()
                    .Setup(job => job.Agent).Use<PersonSource>()
                    .Setup(job => job.Agency).Use<CompanySource>()
                    .Setup(job => job.AgencyLink).Use<WebsiteSource>()
                    .Setup(job => job.AgentPhone).Use<PhoneSource>()
                    .Setup(job => job.Company).Use<CompanySource>()
                    .Setup(job => job.Skills).Use<LoremIpsumSource>();
            });

            IGenerationSession session = factory.CreateSession();
            var jobs = session.List<Job>(250).Get().ToList();

            jobs.ForEach(job => context.Jobs.Add(job));
            context.SaveChanges();
        }
    }
}