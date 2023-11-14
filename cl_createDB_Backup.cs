using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{

    class db_backup
    {
        public void CreateDB_Backup(string strDescription)
        {
            string strDateAndTime = DateTime.Now.ToString("'bk_'yyyyMMdd'_'HHmm'_'");
            string strBackupName = strDateAndTime +
                "_" +
                strDescription +
                "_" +
                "Astrophotography.db";
            var strAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] strWorkPath = { strAppDataFolder, "APU Data" };
            var strfullPath = Path.Combine(strWorkPath);
            try
            {
                File.Copy(Path.Combine(strfullPath, "Astrophotography.db"), Path.Combine(strfullPath, strBackupName), true);
            }
            catch 
            {
                MessageBox.Show("DB backup failed");
            }

           
        }
    }

}
