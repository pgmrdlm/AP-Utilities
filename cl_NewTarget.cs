using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU___Astrophotorophy_Utilities
{
    class db_New_Target
    {
        public void BuildNewTarget
            (
            string strInputFolderPath, 
            string strTarget, 
            string strMount, 
            string strICamera, 
            string strLens, 
            string strFilter, 
            string strGCamera, 
            string strGScope, 
            string strLocation,
            string strBortle
            )
        {
            db_ATI_Table ATI_Table = new db_ATI_Table();
            db_ATID_Table ATID_Table = new db_ATID_Table();
            db_ATIDE_Table ATIDE_Table = new db_ATIDE_Table();

            ATI_Table.BuildATI(strTarget, strMount, strICamera, strLens, strFilter, strGCamera, strGScope, strLocation, strBortle);
            string[] paths = { strInputFolderPath, strLens };
            var strfullPath = Path.Combine(paths);
            string[] arrDirectories = Directory.GetDirectories(strfullPath, "Light_*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < arrDirectories.Length; i++)
            {
                var strDateFolderName = Path.GetFileName(arrDirectories[i]);
                var strDate = strDateFolderName.Substring(6, 4) + strDateFolderName.Substring(11, 2) + strDateFolderName.Substring(14, 2);
                try
                {
                    string result = DateTime.ParseExact(strDate, "yyyyMMdd",
                        CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                    ATID_Table.BuildATID(strTarget, strLens, strDate);
                    //
                    // Add the code for the exposure rows to be added
                    //
                    string[] arrExposureDirectories = Directory.GetDirectories(arrDirectories[i], "Light_*", SearchOption.TopDirectoryOnly);
                    //
                    // Loop through the exposure folders and add them to the Exposure table
                    //
                    for (int y = 0; y < arrExposureDirectories.Length; y++)
                    {
                        var strExposureFolderName = Path.GetFileName(arrExposureDirectories[y]);
                        string[] arrExposureFolder = strExposureFolderName.Split('_');
                        Decimal decExposure = 0;
                        try
                        {
                            decExposure = Convert.ToDecimal(arrExposureFolder[1]);
                        }
                        catch
                        {
                            decExposure = Convert.ToDecimal(arrExposureFolder[2]);
                        }
                        int fCount = Directory.GetFiles(arrExposureDirectories[y], "*", SearchOption.TopDirectoryOnly).Length;
                        ATIDE_Table.BuildATIDE(
                            strTarget,
                            strLens, 
                            strDate, 
                            decExposure, 
                            fCount);
                    }
                }
                catch
                {

                }

            }
        }

    }
}
