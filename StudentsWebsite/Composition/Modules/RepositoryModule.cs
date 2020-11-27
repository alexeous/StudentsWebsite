using Autofac;
using StudentsWebsite.DataAccess.Repositories;
using StudentsWebsite.DataAccess.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Composition.Modules
{
    class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TeacherRepository>().As<ITeacherRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MarkRepository>().As<IMarkRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
        }
    }
}
