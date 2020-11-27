using Autofac;
using StudentsWebsite.Business.Password;
using StudentsWebsite.Business.Password.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Composition.Modules
{
    class PasswordModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NoHashingPasswordService>().As<IPasswordService>().InstancePerLifetimeScope();
        }
    }
}