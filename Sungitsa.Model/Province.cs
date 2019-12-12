using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public IEnumerable<Lodge> Lodges { get; set; }
        public IEnumerable<Apartment> Apartments { get; set; }
        public IEnumerable<Hotel> Hotels { get; set; }
    }
}
