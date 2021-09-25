using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteleCastele.Entity
{
    class EntCity
    {
        public EntCity()
        {

        }
        public EntCity(string Nume)
        {
            location_name = Nume;
        }
        public int location_id { get; set; }
        public string Numele_loc;
        public string location_name { get { return Numele_loc; } set { Numele_loc = value; } }
        public int country_id { get; set; }
    }
}
