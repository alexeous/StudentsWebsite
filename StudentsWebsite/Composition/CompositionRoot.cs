﻿using Autofac;
using Autofac.Integration.Mvc;
using StudentsWebsite.Composition.Modules;
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
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule(new UniversityDbContextModule());
            builder.RegisterModule(new RepositoryModule());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}