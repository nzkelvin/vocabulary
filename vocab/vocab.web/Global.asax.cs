using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using vocab.datamodel.sql;
using vocab.model.Interfaces;

namespace vocab.web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterDependencyResolver();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterDependencyResolver()
        {
            var kernel = new StandardKernel();
            RegisterServices(kernel);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }

        private void RegisterServices(StandardKernel kernel)
        {
            kernel.Bind<IWordRepo>().To<WordRepo>();
        }


    }
}
