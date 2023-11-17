using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace APU___Astrophotorophy_Utilities
{
    // 
    // ArchiveFolders class is used to compress data folders into a 7 zip file.  The application 7zip must be installed
    // on the computer for this process to work.  7 zip will compress a folder up to 40 percent which when dealing with
    // Astro Images folders that can be several gig of size, is a huge savings in space.
    // 
    // 7-Zip is licensed under the GNU LGPL license and(3) you must give a link to www.7-zip.org
    //
    class ArchiveFolders
    {
        public void Run7Zip(string strInputFolder, string strOutputFolder)
        {
           try
            {
                string strWorkName = Path.GetFileName(strInputFolder);
                strWorkName = strWorkName + ".7z";
                string[] strWorkPath = { strOutputFolder, strWorkName };
                var strfullPath = Path.Combine(strWorkPath);
                string strWhatToZip = strInputFolder + "\\*";
                Process.Start("7z", $"a -t7z \"{strfullPath}\" \"{strWhatToZip}\"");
                
            }
           catch (Exception ex) 
            {
                MessageBox.Show("archive failed");
            }

            MessageBox.Show("Data Folder has been archived ");
        }
    }
}
