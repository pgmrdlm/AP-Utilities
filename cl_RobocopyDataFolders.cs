using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace APU___Astrophotorophy_Utilities
{
    internal class RoboCopyData
    {
        /*CopyFolders - Class used to robocopy folders of image data.  If additional options are provided
        output folders will be compressed withy 7-zip and or the input folder will be deleted. 
       */
        
            public string strInputFolder;
            public string strOutputFolder;
            public void RunRobocopy(string strInputFolder, string strOutputFolder)
            {
                string strFolderName1 = Path.GetFileName(strInputFolder);
                strOutputFolder = Path.Combine(strOutputFolder, strFolderName1);
                Process p = Process.Start("robocopy", string.Format("\"{0}\" \"{1}\" /E /DCOPY:DAT", strInputFolder, strOutputFolder));
                p.WaitForExit();
                MessageBox.Show("Data Folder copy complete. ");
            }
       
    }
}
