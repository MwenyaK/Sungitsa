using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sungitsa.Model
{
     public class VacationPackage
    {
        public int VacationPackageId { get; set; }
        public string VacationPackageType { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
