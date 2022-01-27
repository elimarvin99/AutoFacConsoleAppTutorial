using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFacConsoleUI.Utilities;

namespace AutoFacConsoleUI
{
    public class BusinessLogic : IBusinessLogic
    {
        //these properties will be defined by the constructor and are on the class level
        ILogger _logger;
        IDataAccess _dataAccess;
        //the constructor passes in the instances that it will need for the processdata method
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            //we depend on these classes thats why we have to generate them to access their methods
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            _logger.Log("Starting the processing of data.");
            //simulates retriecving data from a database
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
