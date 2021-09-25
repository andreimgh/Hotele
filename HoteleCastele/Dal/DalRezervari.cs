using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    class DalRezervari
    {
        public DataTable GetRezervation()
        {
            DataTable dt = new DataTable();
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("GETRezervation");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cursorul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
                return null;
            }
        }

        public void DeleteRezervation(int id)
        {
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("DeleteRezervation");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;
                cmd.ExecuteScalar();
               
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
                
            }
        }
    }
}
