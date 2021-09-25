using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    class DalRoom
    {
        public DataSet GetRoom(string Name)
        {
            DataSet ds = new DataSet("roomtype12");
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("Get_Room");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("H_Name", OracleDbType.Varchar2).Value = Name;
                cmd.Parameters.Add("cursoru", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ds.Tables.Add(dt);
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
            return ds;
        }
    }
}
