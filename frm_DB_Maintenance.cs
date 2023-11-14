using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{
    public partial class frm_DB_Maint : Form
    {
        public frm_DB_Maint()
        {
            InitializeComponent();
        }

        private void cmb_Select_DB_Maint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Select_DB_Maint.SelectedIndex == 0)
            {
                lbl_DB_Backups.Visible = true;
                lsb_DB_Backups.Visible = true;
                var strAppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string[] strWorkPath = { strAppDataFolder, "APU Data" };
                var strfullPath = Path.Combine(strWorkPath);
                DirectoryInfo strBackupDir = new DirectoryInfo(strfullPath);
                FileInfo[] arrBackupFiles = strBackupDir.GetFiles("bk_*.db"); //Getting Text files
                string str = "";

                foreach (FileInfo strBackupFile in arrBackupFiles)
                {
                    lsb_DB_Backups.Items.Add(strBackupFile.Name);
                }
            }
        }
        
        private void lsb_DB_Backups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var strRestoreFile =  lsb_DB_Backups.SelectedItem.ToString();
            db_Restore RestoreDatabase = new db_Restore();
            RestoreDatabase.Restore_DB(strRestoreFile);
            MessageBox.Show("Database has been restored from " + strRestoreFile);
            this.Close();
        }
    }
}
