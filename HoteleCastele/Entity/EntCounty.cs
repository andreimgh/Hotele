using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteleCastele.Entity
{
    class EntCounty
    {
        public string Numele_tara;
        public EntCounty(string country_name)
        {
            this.country_name = country_name;
        }
        public EntCounty()
        {

        }
        public int country_id { get; set; }
        public string country_name { get { return Numele_tara; } set { Numele_tara = value; } }
    }
}
