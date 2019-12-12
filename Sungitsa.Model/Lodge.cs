using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
    public class Lodge
    {
        public int LodgeId { get; set; }
        public string LodgeName { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
