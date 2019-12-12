using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }

        public int ProviceId { get; set; }
        public Province Province { get; set; }
    }
}
