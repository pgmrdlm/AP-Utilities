using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APU___Astrophotorophy_Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SQLite;
    using System.IO;
    using System.Diagnostics;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using System.Data;

    namespace APU___Astrophotorophy_Utilities
    {
        public class db_AE_Table
        {
            

            public List<string> strImageCamera = new List<string>();
            public List<string> strMount = new List<string>();
            public List<string> strImageLensTelescope = new List<string>();
            public List<string> strFilter = new List<string>();
            public List<string> strGuideCamera = new List<string>();
            public List<string> strGuideScope = new List<string>();
            public void LoadEquipmentForm()
            {
                var connectionString = Resource1.db_connection;
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    bool result = false;
                    SQLiteCommand command =
                         new SQLiteCommand(
                             "SELECT AE.Equipment_Type_Id, AE_Equipment_Name FROM Astro_Equipment AE", conn
                             );
                    using (SQLiteDataReader EquipmentReader =  command.ExecuteReader())
                    {
                        while (EquipmentReader.Read()) 
                        {
                            int intEquipmentId = EquipmentReader.GetInt32(EquipmentReader.GetOrdinal("Equipment_Type_Id"));
                            string strEquipmentNamed = EquipmentReader["AE_Equipment_Name"].ToString();

                            if (intEquipmentId == 1)
                            {
                                strImageCamera.Add(strEquipmentNamed);
                            }
                            if (intEquipmentId == 2)
                            {
                                strGuideCamera.Add(strEquipmentNamed);
                            }
                            if (intEquipmentId == 3)
                            {
                                strMount.Add(strEquipmentNamed);
                            }
                            if (intEquipmentId == 8)
                            {
                                strFilter.Add(strEquipmentNamed);
                            }
                            if (intEquipmentId == 9)
                            {
                                strImageLensTelescope.Add(strEquipmentNamed);
                            }
                            if (intEquipmentId == 10)
                            {
                                strGuideScope.Add(strEquipmentNamed);
                            }

                            string strMessageBox = intEquipmentId + " " + strEquipmentNamed;
                            
                        }
                        
                        conn.Clone();
                    }
                    
                }


            }
        }
    }

}
