using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{

    class db_Restore
    {
        public void Restore_DB(string strRestoreFile)
        {
            var strAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] strWorkPath = { strAppDataFolder, "APU Data" };
            var strfullPath = Path.Combine(strWorkPath);

            try
            {
                File.Copy(Path.Combine(strfullPath, strRestoreFile), Path.Combine(strfullPath, "Astrophotography.db"), true);
            }
            catch
            {
            }
           

        }
    }

}
