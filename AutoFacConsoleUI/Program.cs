using System;
using Autofac;


namespace AutoFacConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        var container = AutoFacConfig.Configure();

        using (var scope = container.BeginLifetimeScope())
        {
            //give me an iapplication which returns an instance of application that contains a run method
            var app = scope.Resolve<IApplication>();
            //this calls the ibusiness logic that returns a business logic that requires in its constructor an ilogger idataaccess
            app.Run();  
        }
    }
}


