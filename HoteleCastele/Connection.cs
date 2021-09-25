using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele
{
    public class Connection
    {
        public static string Conectiune
        {
            get
            {
                string conn = ConfigurationManager.ConnectionStrings["Connection"].ToString();

                OracleConnectionStringBuilder sb = new OracleConnectionStringBuilder(conn);
                return sb.ToString();
            }
        }

        public static OracleConnection GetOracleConnection()
        {
            OracleConnection conn = new OracleConnection(Conectiune);
            try
            {
                conn.Open();
            }
            catch (Exception ss)
            {
                string gg = ss.Message;
            }
            return conn;
        }
    }
}
