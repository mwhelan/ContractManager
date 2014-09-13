using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ContractManager.Infrastructure.Data;
using ContractManager.Web.App_Start;

namespace ContractManager.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            IocConfig.RegisterDependencies();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DatabaseConfig.InitializeDatabase();
        }
    }
}
