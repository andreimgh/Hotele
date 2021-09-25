using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Dal
{
    
    class DalExport
    {
        Dal.DalRezervari DalRezervari = new DalRezervari();

        public void Export()
        {
            DataTable dt = new DataTable();
            dt = DalRezervari.GetRezervation();
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText("D:\\Text.csv", sb.ToString());

        }

        public DataTable Import()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader("D:\\Text.csv");
            string[] Head = sr.ReadLine().Split(',');
            foreach(string Header in Head)
            {
                dt.Columns.Add(Header);
            }
            while(!sr.EndOfStream)
            {
                string[] row = Regex.Split(sr.ReadLine(), ",");
                DataRow dr = dt.NewRow();
                for (int i=0;i<Head.Length;i++)
                {
                    dr[i] = row[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
   
}
