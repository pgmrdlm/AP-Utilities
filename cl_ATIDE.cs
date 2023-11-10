using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APU___Astrophotorophy_Utilities
{
    class db_ATIDE_Table
    {
        public void BuildATIDE(
            string strTargetName,
            string strLens, 
            string strCCYYMMDD, 
            decimal decExposure,
            int intTotalExposures)
        {
            db_Create_ConnectionString db_ConnectionString = new db_Create_ConnectionString();
            var connectionString = db_ConnectionString.CreateConnectionString();
            //var connectionString = db_Astro_Connection.db_connection;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                bool bolAddRows = false;
                var BuildATIDE = ATIDE_Resources.BldATIDE;
                SQLiteCommand command =
                     new SQLiteCommand(BuildATIDE, conn);
                command.Parameters.Add(new SQLiteParameter("@Target", strTargetName));
                command.Parameters.Add(new SQLiteParameter("@Lens", strLens));
                command.Parameters.Add(new SQLiteParameter("@CCYYMMDD", strCCYYMMDD));
                command.Parameters.Add(new SQLiteParameter("@Exposure", decExposure));
                command.Parameters.Add(new SQLiteParameter("@TltExposures", intTotalExposures));

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
