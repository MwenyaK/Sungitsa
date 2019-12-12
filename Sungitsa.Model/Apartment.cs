using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
