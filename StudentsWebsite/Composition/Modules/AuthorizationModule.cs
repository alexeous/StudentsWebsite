using Autofac;
using StudentsWebsite.Business.Authorization;
using StudentsWebsite.Business.Authorization.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Composition.Modules
{
    class AuthorizationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthorizationService>().As<IAuthorizationService>().InstancePerLifetimeScope();
        }
    }
}