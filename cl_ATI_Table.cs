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
using APU___Astrophotorophy_Utilities.APU___Astrophotorophy_Utilities;

namespace APU___Astrophotorophy_Utilities
{
    class db_ATI_Table
    {
        public bool QueryATI(string strTargetName, string strEquipment)
        {

            db_Create_ConnectionString db_ConnectionString = new db_Create_ConnectionString();
            var connectionString = db_ConnectionString.CreateConnectionString();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                bool result = false;
                var CheckForTarget = ATI_Resources.CheckForTarget;
                SQLiteCommand command = new SQLiteCommand(CheckForTarget, conn);
                command.Parameters.Add(new SQLiteParameter("@Target", strTargetName));
                command.Parameters.Add(new SQLiteParameter("@Lens", strEquipment));

                using (SQLiteDataReader TargetReader = command.ExecuteReader())
                {
                    int i = 0;

                    if (TargetReader.HasRows)
                    {
                        result = true;
                        conn.Close();
                        conn.Dispose();
                        SQLiteConnection.ClearAllPools();
                        GC.Collect();

                        return result;
                    }
                    else
                    {
                        result = false;
                        conn.Close();
                        conn.Dispose();
                        SQLiteConnection.ClearAllPools();
                        GC.Collect();

                        return result;
                    }
                }
                  
               
                result = false;
                conn.Close();
                conn.Dispose();
                SQLiteConnection.ClearAllPools();
                GC.Collect();

                return result;
            }
           

        }
        public void BuildATI(string strTargetName, string strMount, string strICamera, string strTelescope, string strFilter, string strGuidCamera, string strGuideScope, string strLocation, string strBortle)
        {
            db_backup BackupDataBase = new db_backup();
            var strBackupDescription = "Before_New_Target_" +
                strTargetName;
            BackupDataBase.CreateDB_Backup(strBackupDescription);
            db_Create_ConnectionString db_ConnectionString = new db_Create_ConnectionString();
            var connectionString = db_ConnectionString.CreateConnectionString();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                bool result = false;
                var strQuery = ATI_Resources .BuildATI;
                SQLiteCommand command =
                     new SQLiteCommand(strQuery, conn);
                command.Parameters.Add(new SQLiteParameter("@Target", strTargetName));
                command.Parameters.Add(new SQLiteParameter("@Mount", strMount));
                command.Parameters.Add(new SQLiteParameter("@ICamera", strICamera));
                command.Parameters.Add(new SQLiteParameter("@Telescope", strTelescope));
                command.Parameters.Add(new SQLiteParameter("@Filter", strFilter));
                command.Parameters.Add(new SQLiteParameter("@GCamera", strGuidCamera));
                command.Parameters.Add(new SQLiteParameter("@GScope", strGuideScope));
                command.Parameters.Add(new SQLiteParameter("@Location", strLocation));
                command.Parameters.Add(new SQLiteParameter("@Bortle", strBortle));

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                            
                conn.Close();
                conn.Dispose();
                SQLiteConnection.ClearAllPools();
                GC.Collect();

            }


        }
    }
}
