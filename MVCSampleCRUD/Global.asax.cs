using Microsoft.Practices.Unity;
using Sample.SalesService.BLL;
using Sample.SalesService.DAL;
using Sample.SalesService.Factories;
using Sample.SalesService.Services;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity.Mvc4;

namespace MVCSampleCRUD
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new UnityDependencyResolver(this.BuildUnityContainer()));
        }

        private IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterInstance<ISalesService>(SalesServiceFactory.GetSalesService());

            return container;
        }
    }
}
