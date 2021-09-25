using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HoteleCastele.Entity
{
    class EntFinal
    {
        
        public EntFinal()
        {

        }
        public EntFinal(string Country_name, string Location_name, string hotel_name)
        {
            country_name = Country_name;
            location_name = Location_name;
            Hotel_name = hotel_name;
        }
        public string Numele_tara;
        public string Numere_oras;
        public string Numele_Hotel;
        public string country_name { get { return Numele_tara; } set { Numele_tara = value; } }
        public string location_name { get { return Numere_oras; } set { Numere_oras = value; } }
        public string Hotel_name { get { return Numele_Hotel; } set { Numele_Hotel = value; } }
        public void Load(OracleDataReader reader)
        {
            country_name = reader["country_name"].ToString();
            location_name = reader["location_name"].ToString();
            Hotel_name = reader["hotel_name"].ToString();
        }
    }
}
