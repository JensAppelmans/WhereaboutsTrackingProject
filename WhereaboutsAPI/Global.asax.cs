using Autofac;
using Autofac.Integration.WebApi;
using Whereabouts.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Whereabouts.API.Controllers;
using Whereabouts.Core;
using Whereabouts.DAL.Repositories;
using Whereabouts.Core.Repositories;
using Whereabouts.DAL.Migrations;
using AutoMapper;
using Whereabouts.API;

namespace Whereabouts
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            builder.RegisterInstance(autoMapperConfig.CreateMapper()).As<IMapper>().SingleInstance(); 

            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DatabaseContext>().AsSelf();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);


        }
    }
}
