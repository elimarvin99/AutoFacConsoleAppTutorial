using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacConsoleUI
{
    //because we use constructors to create properties for our business logic class we cant do it in program because its static and has no constructors
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
