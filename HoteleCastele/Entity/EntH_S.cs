using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteleCastele.Entity
{
    class EntH_S
    {
        public int H_S_id { get; set; }
        public string H_S_Description { get; set; }
        public string H_S_Type { get; set; }

        public string H_S_Active { get; set; }
        public DateTime H_S_Created_on { get; set; }
        public string H_S_Created_By { get; set; }
        public DateTime H_S_Updated_on { get; set; }
        public string H_S_Updated_By { get; set; }
        public int hotel_id { get; set; }
    }
}
