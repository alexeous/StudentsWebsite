using Autofac;
using StudentsWebsite.Business.Registration;
using StudentsWebsite.Business.Registration.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Composition.Modules
{
    class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRegistrationService>().As<IUserRegistrationService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentRegistrationService>().As<IStudentRegistrationService>().InstancePerLifetimeScope();
            builder.RegisterType<TeacherRegistrationService>().As<ITeacherRegistrationService>().InstancePerLifetimeScope();
        }
    }
}