using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.SubcomponentDTOs
{
    public class SubcomponentDTO
    {
        public int SubcomponentID { get; set; }

        public int InjectorID { get; set; }

        public int StationID { get; set; }

        public decimal SubcomponentCost { get; set; }
    }
}
