using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using StudentsWebsite.Composition.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace StudentsWebsite.Composition
{
    public static class CompositionRoot
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterModule(new UniversityDbContextModule());
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new RegistrationModule());

            var container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
