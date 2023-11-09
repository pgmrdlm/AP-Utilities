using APU___Astrophotorophy_Utilities.APU___Astrophotorophy_Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{
    class VerifyFolders
    {

        public List<string> lstEquipment = new List<string>();

        public void VerifyEquipmentFolders(string strInputFolderPath)
        {
            // Targets can be imaged different times with different equipment which can be determined by the 
            // directories directly under the target main folder.  Grab all these folder names to see if this
            // image session already exists but we are only copying over another nights image session on the targeto

            string[] arrDirectories = Directory.GetDirectories(strInputFolderPath, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < arrDirectories.Length; i++)
            {
                arrDirectories[i] = Path.GetFileName(arrDirectories[i]);
                db_AE_Table AE_Table = new db_AE_Table();
                bool bolValidEquipment = AE_Table.VerifyEquipmentFolders(arrDirectories[i]);

                if (bolValidEquipment == true)
                {
                    var strTargetName = Path.GetFileName(strInputFolderPath);
                    db_ATI_Table ATI_Table = new db_ATI_Table();
                    bool bolEquipmentExists = ATI_Table.QueryATI(strTargetName, arrDirectories[i]);
                    if (bolEquipmentExists == true)
                    {

                        return;
                    }
                   //
                   VerifyFolders CheckDateFolders = new VerifyFolders();
                   string[] paths = { strInputFolderPath, arrDirectories[i] };
                   var strfullPath = Path.Combine(paths);
                   int intReturnedDateCount = CheckDateFolders.VerifyDateFolders(strfullPath);
                   lstEquipment.Add(arrDirectories[i]);
                } else
                {
                    MessageBox.Show("Target sub folder " + arrDirectories[i] + " Is not a valid equipment name");
                }
            }
           
        }
        //  }
        public int VerifyDateFolders(string strFullDatePath)
        {
            int intValidDatates = 0;

            string[] arrDirectories = Directory.GetDirectories(strFullDatePath, "Light_*", SearchOption.TopDirectoryOnly);
            var strDateFolder = Path.GetFileName(strFullDatePath);
            //
            // Verifies that there is at least 1 valid date folder under the equipment folder
            //
            for (int i = 0; i < arrDirectories.Length; i++)
            {
                var strDateFolderName = Path.GetFileName(arrDirectories[i]);
                var strDate= strDateFolderName.Substring(6,4) + strDateFolderName.Substring(11, 2) + strDateFolderName.Substring(14,2);
                try
                {
                    string result = DateTime.ParseExact(strDate, "yyyyMMdd",
                        CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                   

                    intValidDatates = intValidDatates + 1;
                }
                catch {
                }
               
            }
            return intValidDatates;
        }

        public void VerifyDateFolders(string strFullDatePath, string strFlag)
        {
            string[] arrEquipmentDirectories = Directory.GetDirectories(strFullDatePath, "*", SearchOption.TopDirectoryOnly);
            var strTarget = Path.GetFileName(strFullDatePath);
            
            var strPath = arrEquipmentDirectories[0];
            var strLens = Path.GetFileName(strPath);
            string[] arrDateDirectories = Directory.GetDirectories(strPath, "Light_*", SearchOption.TopDirectoryOnly);
            
            
            //
            // Verifies that there is at least 1 valid date folder under the equipment folder
            //
            for (int i = 0; i < arrDateDirectories.Length; i++)
            {
                var strDateFolderName = Path.GetFileName(arrDateDirectories[i]);
                var strDate = strDateFolderName.Substring(6, 4) + strDateFolderName.Substring(11, 2) + strDateFolderName.Substring(14, 2);
                try
                {
                    string strCheckDate = DateTime.ParseExact(strDate, "yyyyMMdd",
                        CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                    db_ATID_Table ATID_Table = new db_ATID_Table();
                    ATID_Table.BuildATID(strTarget, strLens, strDate);
                }
                catch
                {
                }

            }
            
        }
    }
}

