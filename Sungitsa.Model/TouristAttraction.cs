using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
    public class TouristAttraction
    {
        public int TouristAttractionId { get; set; }
        public string TouristAttractionName { get; set; }
        public int ProviceId { get; set; }
        public Province Province { get; set; }
    }
}
