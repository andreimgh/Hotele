using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteleCastele.Dal
{
    class DalMoneda
    {
        public List<string> moneda(string semn)
        {
            List<string> date = new List<string>();
            if(semn=="$")
            {
                date.Add("{0:c}");
                date.Add("1");
                date.Add("en-US");
            }
            if (semn == "R")
            {
                date.Add("{0:c}");
                date.Add("11.04");
                date.Add("tn-BW");
            }
            if(semn== "¥")
            {
                date.Add("{0:c}");
                date.Add("106.39");
                date.Add("ja-JP");
            }
            if(semn== "£")
            {
                date.Add("{0:c}");
                date.Add("0.83");
                date.Add("en-GB");
            }
            return date;
        }
    }
}
