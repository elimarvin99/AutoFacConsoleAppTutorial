namespace AutoFacConsoleUI.Utilities
{
    public class DataAccess : IDataAccess
    {
        public DataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }
        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
        }
    }
}