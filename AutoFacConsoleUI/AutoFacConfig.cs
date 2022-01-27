using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacConsoleUI
{
    public static class AutoFacConfig
    {
        //this class contains only one method and that is to configure the container
        //returns a Icontainer based on specifications defined in the method
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //the application actually constructs the business logic to be run by the processdata method
            builder.RegisterType<Application>().As<IApplication>(); 
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>(); //whenever you look for ibusinesslogic return an instance of business logic
            //respond with business logic whenever ibusiness is needed

            //here we are getting the classes and mathcing them up to their interface (getting assemblytypes(classes) as the interfaces)
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(AutoFacConsoleUI)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name)); //t is class, t should be returned when i (interface) is called

            //this will return the built container with all of our configurations and classes we want to instantiate
            return builder.Build();
        }
    }
}
