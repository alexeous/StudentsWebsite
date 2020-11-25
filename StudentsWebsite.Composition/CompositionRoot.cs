using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace StudentsWebsite.Composition
{
    public static class CompositionRoot
    {
        public static void RegisterDependencies(Assembly mvcApplicationAssembly)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(mvcApplicationAssembly);


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
