using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteleCastele.Entity
{
    class EntHotel
    {
        public EntHotel()
        {

        }
        public string Numele_hot;
        public EntHotel(string Name)
        {
            Hotel_name = Name;
        }
        public int Hotel_id { get; set; }
        public string Hotel_name { get { return Numele_hot; } set { Numele_hot = value; } }
        public int location_id { get; set; }
    }
}
