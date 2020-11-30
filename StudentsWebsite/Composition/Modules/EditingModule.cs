using Autofac;
using StudentsWebsite.Business.Editing;
using StudentsWebsite.Business.Editing.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Composition.Modules
{
    class EditingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentEditingService>().As<IStudentEditingService>().InstancePerLifetimeScope();
        }
    }
}