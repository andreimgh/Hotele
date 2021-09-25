using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    class DalHotel
    {
        public List<String> Hotel(string l_name)
        {
            List<string> Hotel = new List<string>();
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("Get_Hotel");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Location_name", OracleDbType.Varchar2).Value = l_name;
                cmd.Parameters.Add("cursorul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Hotel.Add("Select Hotel");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["location_name"]).ToString() == l_name)
                    {
                        Hotel.Add(dt.Rows[i]["Hotel_name"].ToString());
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
            return Hotel;
        }

        public DataTable GetAll()
        {
            try
            {
                OracleConnection conn = Connection.GetOracleConnection();
                OracleCommand cmd = new OracleCommand("GETALL", conn);
                DataTable dt = new DataTable();
                List<Entity.EntFinal> combinat = new List<Entity.EntFinal>();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                cmd.Parameters.Add("cursorul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Entity.EntFinal obj = new Entity.EntFinal();
                    obj.country_name = dr["Tara"].ToString();
                    obj.location_name = dr["Orasul"].ToString();
                    obj.Hotel_name = dr["Hotel Name"].ToString();
                    combinat.Add(obj);
                }

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
    }
}
