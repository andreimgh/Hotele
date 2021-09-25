using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteleCastele.Entity
{
    class EntRoom
    {
        public int Room_int { get; set; }
        public string room_name { get; set; }
        public char Status { get; set; }
        public DateTime created_on { get; set; }
        public string created_by { get; set; }
        public int hotel_id { get; set; }
    }
}
