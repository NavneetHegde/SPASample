using Microsoft.Practices.Unity;
using Sample.API.Repository;
using Sample.API.Repository.Interfaces;
using Sample.API.Unity;
using System.Web.Http;

namespace Sample.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IAccountRepository, AccountRepository>(new ContainerControlledLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //enabe cross orgin
            config.EnableCors();

        }
    }
}
