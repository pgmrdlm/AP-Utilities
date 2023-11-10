using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APU___Astrophotorophy_Utilities
{
    class db_Create_ConnectionString
    {
        public string CreateConnectionString()
        {
            var strAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] strPaths = { @strAppDataPath, "APU Data", "Astrophotography.db"};
            var strFullDBPath = Path.Combine(strPaths);
            //Data Source=..\\..\\Astrophotography DataBase\\Astrophotography.db;Version=3;
            var strConnectionString = "Data Source=" +
                strFullDBPath +
                ";Version=3;";
            return strConnectionString;
        }
    }
}
