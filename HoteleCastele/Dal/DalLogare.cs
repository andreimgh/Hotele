using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    class DalLogare
    {
        public List<bool> Verificare(string Id, string parola)
        {
            List<bool> Verificare = new List<bool>();
            OracleConnection conn = Connection.GetOracleConnection();
            OracleCommand cmd = new OracleCommand("login",conn);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            cmd.Parameters.Add("Idu", OracleDbType.Varchar2).Value = Id;
            cmd.Parameters.Add("Parol", OracleDbType.Varchar2).Value = parola;

            OracleParameter p1 = new OracleParameter("Verificareid", OracleDbType.Boolean, ParameterDirection.Output);
            OracleParameter p2 = new OracleParameter("Verificareps", OracleDbType.Boolean, ParameterDirection.Output);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.ExecuteScalar();
            Verificare.Add(Convert.ToBoolean(p1.Value.ToString()));
            Verificare.Add(Convert.ToBoolean(p2.Value.ToString()));
        
            return Verificare;
        }
    }
}
