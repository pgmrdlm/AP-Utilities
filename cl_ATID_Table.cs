using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APU___Astrophotorophy_Utilities
{
    class db_ATID_Table
    {


        public bool QueryATID(string strTargetName, string strCaera, string strCCYYMMDD)
        {

            var connectionString = db_Astro_Connection.db_connection;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                bool bolAddRows = false;
                var CheckForTarget = ATI_Resources.CheckForTarget;
                SQLiteCommand command =
                     new SQLiteCommand(CheckForTarget, conn);
                command.Parameters.Add(new SQLiteParameter("@Target", strTargetName));
                using (SQLiteDataReader TargetReader = command.ExecuteReader())
                {

                    if (TargetReader.HasRows)
                    {

                        bolAddRows = false;
                        conn.Close();
                        SQLiteConnection.ClearAllPools();
                        GC.Collect();

                    }
                    bolAddRows = true;
                    conn.Close();
                    conn.Dispose();
                    SQLiteConnection.ClearAllPools();
                    GC.Collect();
                    return bolAddRows;
                }

                bolAddRows = true;
                conn.Close();
                conn.Dispose();
                SQLiteConnection.ClearAllPools();
                GC.Collect();
                return bolAddRows;
            }


        }
        public void BuildATID(string strTargetName, string strLens, string strCCYYMMDD)
        {

            var connectionString = db_Astro_Connection.db_connection;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                bool bolAddRows = false;
                var BuildATID = ATID_Resources.BldATID;
                SQLiteCommand command =
                     new SQLiteCommand(BuildATID, conn);
                command.Parameters.Add(new SQLiteParameter("@Target", strTargetName));
                command.Parameters.Add(new SQLiteParameter("@Lens", strLens));
                command.Parameters.Add(new SQLiteParameter("@CCYYMMDD", strCCYYMMDD));

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
