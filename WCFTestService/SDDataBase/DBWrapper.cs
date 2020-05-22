using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDataBase
{
    public class DBWrapper
    {
        private static string CONNECTION_STRING = "Provider=OraOLEDB.Oracle;Data Source=DAILY_STAT;user id=waldekd;password=waldekd123;PLSQLRSet=1;";//"Provider=MSDAORA;DataSource=\"(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=sccdrdb1p.dr.softcomputer.com)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=sd.dr.softcomputer.com)))\";UserID=waldekd;Password=waldekd123";

        public static string GetBurnDownData()
        {
            OleDbConnection conn = new OleDbConnection(CONNECTION_STRING);

            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM DEV1_BURNDOWN2";
                //reader = cmd.ExecuteReader();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                }

            }
            finally
            {
                conn.Close();
            }

            return ds.GetXml();
        }


    }
}
