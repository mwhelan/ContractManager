using ContractManager.Domain;
using ContractManager.Domain.Model;
using FizzWare.NBuilder;

namespace ContractManager.Infrastructure.Data
{
    public class SeedData
    {
        public static void Create(DatabaseContext context)
        {
            var agencies = Builder<Agency>.CreateListOfSize(100).Build();
            agencies.Each(agency => context.Agency.Add(agency));
            context.SaveChanges();

            var agents = Builder<Agent>.CreateListOfSize(150)
                .All().Do(agent => agent.SetAgency(Pick<Agency>.RandomItemFrom(agencies)))
                .Build();
            agents.Each(agent => context.Agents.Add(agent));
            context.SaveChanges();

            var jobs = Builder<Job>.CreateListOfSize(250).All()
                .Do(job => job.SetAgent(Pick<Agent>.RandomItemFrom(agents)))
                .Build();
            jobs.Each(job => context.Jobs.Add(job));
            context.SaveChanges();
        }

        //public static void Create(DatabaseContext context)
        //{
        //    var factory = AutoPocoContainer.Configure(x =>
        //    {
        //        x.Conventions(c => { c.UseDefaultConventions(); });
        //        x.AddFromAssemblyContainingType<Job>();

        //        x.Include<Agency>()
        //            .Setup(agency => agency.Name).Use<CompanySource>()
        //            .Setup(job => job.Website).Use<WebsiteSource>();

        //        x.Include<Agent>()
        //            .Setup(agent => agent.Name).Use<PersonSource>()
        //            .Setup(agent => agent.Email).Use<EmailAddressSource>()
        //            .Setup(agent => agent.Phone).Use<PhoneSource>();

        //        x.Include<Job>()
        //            .Setup(job => job.Location).Use<LocationSource>()
        //            .Setup(job => job.Rate).Use<RateSource>()
        //            .Setup(job => job.Company).Use<CompanySource>()
        //            .Setup(job => job.Skills).Use<LoremIpsumSource>();

        //    });

        //    IGenerationSession session = factory.CreateSession();
        //    var agencies = session.List<Agency>(150).Get().ToList();
        //    var agencies = session.List<Agent>(175)
        //        .Impose(x => x.Agency,  AutoSource<Agency>(agencies))

        //    var jobs = session.List<Job>(250).Get().ToList();

        //    jobs.ForEach(job => context.Jobs.Add(job));
        //    context.SaveChanges();
        //}
    }
}