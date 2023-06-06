using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.EntityLayer.Concrete
{
    public class Subcomponent
    {
        [Key]
        public int SubcomponentID { get; set; }

        public int? InjectorID { get; set; }

        public int StationID { get; set; }

        public decimal SubcomponentCost { get; set; }
    }
}
