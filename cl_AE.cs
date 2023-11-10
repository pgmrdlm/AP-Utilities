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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
    using System.Windows.Forms.VisualStyles;

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
                db_Create_ConnectionString db_ConnectionString = new db_Create_ConnectionString();
                var connectionString = db_ConnectionString.CreateConnectionString();
                //var connectionString = db_Astro_Connection.db_connection;
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    var AE_Select = AE_Resources.SelectEquipment;
                    conn.Open();
                    bool result = false;
                    SQLiteCommand command =
                         new SQLiteCommand(AE_Select, conn);
                    using (SQLiteDataReader EquipmentReader = command.ExecuteReader())
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

                        conn.Close();
                        conn.Dispose();
                        SQLiteConnection.ClearAllPools();
                        GC.Collect();
                    }

                }


            }
            //
            // VerifyEquipmentFolders - Method gets the name of any valid equipment(telescope/lens) folder that is directly
            // under the target folder.  If no folders are returned, then it means that folders are improperly named and
            // will have to be corrected before any rows are added to the data base.
            //
            public bool VerifyEquipmentFolders(string strEquipmentName)
            {
                bool bolValidEquipment = false;
                db_Create_ConnectionString db_ConnectionString = new db_Create_ConnectionString();
                var connectionString = db_ConnectionString.CreateConnectionString();
                //bool bolValidFolder = false;

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    var AE_Select = AE_Resources.VerifyEquipment;
                    SQLiteCommand command = new SQLiteCommand(AE_Select, conn);
                    command.Parameters.Add(new SQLiteParameter("@EQ_Name", strEquipmentName));
                    using (SQLiteDataReader EquipmentReader = command.ExecuteReader())
                    {
                        if (EquipmentReader.HasRows)
                        {
                            bolValidEquipment = true;
                        }
                        conn.Close();
                        conn.Dispose();
                        SQLiteConnection.ClearAllPools();
                        GC.Collect();

                        return bolValidEquipment;
                    }
                    conn.Close();
                    conn.Dispose();
                    SQLiteConnection.ClearAllPools();
                    GC.Collect();

                    return bolValidEquipment;
                }
            }
        }
       
    }
  
}
