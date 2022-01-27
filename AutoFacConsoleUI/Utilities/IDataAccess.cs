using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacConsoleUI.Utilities
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}
