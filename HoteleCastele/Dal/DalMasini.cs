using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    class DalMasini
    {
        public DataTable GetMasini(string Hotele)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("Get_car");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Numele", OracleDbType.Varchar2).Value = Hotele;
                cmd.Parameters.Add("cursorul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
            return dt;
        }
    }
}
