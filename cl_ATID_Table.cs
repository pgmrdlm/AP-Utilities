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


        public bool QueryATID(string strTargetName, string strLens, string strCCYYMMDD)
        {

            var connectionString = db_Astro_Connection.db_connection;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                bool bldHasRows = false;
                var CheckForTarget = ATID_Resources.CheckDateTable;
                SQLiteCommand command =
                     new SQLiteCommand(CheckForTarget, conn);
                command.Parameters.Add(new SQLiteParameter("@Target", strTargetName));
                command.Parameters.Add(new SQLiteParameter("@Lens", strLens));
                command.Parameters.Add(new SQLiteParameter("@Date", strCCYYMMDD));
                using (SQLiteDataReader TargetReader = command.ExecuteReader())
                {

                    if (TargetReader.HasRows)
                    {

                        bldHasRows = true;
                        conn.Close();
                        SQLiteConnection.ClearAllPools();
                        GC.Collect();
                        return bldHasRows;
                    }
                    bldHasRows = false;
                    conn.Close();
                    conn.Dispose();
                    SQLiteConnection.ClearAllPools();
                    GC.Collect();
                    return bldHasRows;
                }

                bldHasRows = true;
                conn.Close();
                conn.Dispose();
                SQLiteConnection.ClearAllPools();
                GC.Collect();
                return bldHasRows;
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
