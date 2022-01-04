using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta
{
    class ContainerConfig
    {
        public static IContainer Configure() 
        {
            var builder = new ContainerBuilder();

           // builder.RegisterType<Application>().As<IApplication> ();
            builder.RegisterType<Facebook>().As<IFacebook> ();

            return builder.Build();
        }
    }
}
