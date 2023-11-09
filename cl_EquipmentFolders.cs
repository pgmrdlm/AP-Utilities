using APU___Astrophotorophy_Utilities.APU___Astrophotorophy_Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{
    class EquipmentFolders
    {

        public List<string> lstEquipment = new List<string>();
        
        public void VerifyEquipmentFolders(string strInputFolderPath)
        {
            // Targets can be imaged different times with different equipment which can be determined by the 
            // directories directly under the target main folder.  Grab all these folder names to see if this
            // image session already exists but we are only copying over another nights image session on the targeto
            db_AE_Table AE_Table = new db_AE_Table();
            string[] arrDirectories = Directory.GetDirectories(strInputFolderPath, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < arrDirectories.Length; i++)
            {
                arrDirectories[i] = Path.GetFileName(arrDirectories[i]);
                bool bolValidEquipment =  AE_Table.VerifyEquipmentFolders(arrDirectories[i]);

                if (bolValidEquipment == true)
                {
                    db_ATI_Table ATI_Table = new db_ATI_Table();
                    var strTargetName = Path.GetFileName(strInputFolderPath);
                    bool bolExists = ATI_Table.QueryATI(strTargetName, arrDirectories[i]);
                    if (bolExists == true)
                    {
                        return;
                    }
                    lstEquipment.Add(arrDirectories[i]);
                } else
                {
                    MessageBox.Show("Target sub folder " + arrDirectories[i] + " Is not a valid equipment name");
                }
            }
        }
    }
}
