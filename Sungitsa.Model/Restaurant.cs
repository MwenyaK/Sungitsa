using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
