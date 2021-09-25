using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    public class DalCity
    {
        public List<String> City(int c_id)
        {
            List<string> City = new List<string>();
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("Get_City");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Country_id", OracleDbType.Int32).Value = c_id;
                cmd.Parameters.Add("cursorul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                City.Add("Select City");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (Convert.ToInt32(dt.Rows[i]["country_id"]) == c_id)
                    {
                        City.Add(dt.Rows[i]["location_name"].ToString());
                    }
                }
            }
            catch (Exception ss)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Erori.txt", true))
                {
                    file.WriteLine(ss.Message);
                }
            }
            return City;
        }
    }
}
