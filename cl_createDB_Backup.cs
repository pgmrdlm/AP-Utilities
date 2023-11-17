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
            DirectoryInfo strBackupDir = new DirectoryInfo(strfullPath);
            FileInfo[] arrBackupFiles = strBackupDir.GetFiles("bk_*.db"); //Getting Text files
            for (int i = 0; i < arrBackupFiles.Length; i++)
            {
                string str = "";
                if (i > 9)
                {

                    var strFileToDelete = arrBackupFiles[i].ToString();
                    strAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string[] strWorkPath1 = { strAppDataFolder, "APU Data", strFileToDelete };
                    var strPathForDelete = Path.Combine(strWorkPath1);
                    File.Delete(strPathForDelete);
                }

                // File.Delete(f);
            }

        }
    }

}
