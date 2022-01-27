namespace AutoFacConsoleUI.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger _logger;
        public DataAccess()
        {

        }
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }

        public void LoadData()
        {
            Console.WriteLine("Loading Data");
            _logger.Log("Loading Data");
        }
        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
            _logger.Log("Saving Data");
        }
    }
}